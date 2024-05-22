using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap_project.Classes;

namespace wap_project.Database
{
    internal class StudentDB
    {
        public void addStudent(Student student)
        {
            const string query = "insert into Student(FirstName, LastName, SubjectName, SubjectYears)" +
                        " values(@FirstName,@LastName,@SubjectName, @SubjectYears);  " +
                        "SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@SubjectName", student.Subject.SubjectName);
                command.Parameters.AddWithValue("@SubjectYears", student.Subject.Years);
                long id = (long)command.ExecuteScalar();
                student.Id = (int)id;
            }
            
        }

        public void loadStudents(List<Student> students)
        {
            const string query = "SELECT * FROM Student";

            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long read_id = (long)reader["Id"];
                        int id = (int)read_id;
                        string lastName = (string)reader["LastName"];
                        string firstName = (string)reader["FirstName"];
                        string subjectName = (string)reader["SubjectName"];
                        long years = (long)reader["SubjectYears"];
                        int yearInt = (int)years;

                        Subject sub = new Subject(subjectName, yearInt);
                        Student stud = new Student(id, firstName, lastName, sub);
                        students.Add(stud);
                    }
                }
               connection.Close();
            }
        }

        public void editStudent(Student student)
        {
            const string query = "Update Student SET FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "SubjectName = @SubjectName," +
                "SubjectYears = @SubjectYears";
            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@SubjectName", student.Subject.SubjectName);
                command.Parameters.AddWithValue("@SubjectYears", student.Subject.Years);

                command.ExecuteScalar();
            }

        }

        public void deleteStudent(Student student)
        {
            const string query = "DELETE FROM Student WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(LoadConnectionString()))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", student.Id);
                command.ExecuteNonQuery();
            }
        }

        public static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
