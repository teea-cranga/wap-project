using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wap_project.Classes;

namespace wap_project.Database
{
    internal class StudentDB
    {
        private const string ConnectionString = "Data Source=database.db";
        public void addStudent(Student student)
        {
            const string query = "insert into Student(FirstName, LastName, SubjectName, SubjectYears)" +
                        " values(@FirstName,@LastName,@SubjectName, @SubjectYears);  " +
                        "SELECT last_insert_rowid()";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
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

        public void loadStudents()
        {
            const string query = "SELECT * FROM Student";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
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
                        Subject sub = new Subject((string)reader["SubjectName"],(int)reader["SubjectYears"]);

                        Student stud = new Student(id, firstName, lastName, sub);
                        students.Add(stud);
                    }
                }
            }
        }

        public Student getStudent(int id)
        {
            const string query = "SELECT * from Student where Id = @Id";
            Student stud = new Student();
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                        long read_id = (long)reader["Id"];
                        stud.Id = (int)read_id;
                        stud.LastName = (string)reader["LastName"];
                        stud.FirstName = (string)reader["FirstName"];
                        stud.Subject = new Subject((string)reader["SubjectName"], (int)reader["SubjectYears"]);
                }

            }
            return stud;
        }

        public void editStudent(Student student)
        {
            const string query = "Update Student SET FirstName = @FirstName, " +
                "LastName = @LastName, " +
                "SubjectName = @SubjectName," +
                "SubjectYears = @SubjectYears";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                var command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@SubjectName", student.Subject.SubjectName);
                command.Parameters.AddWithValue("@SubjectYears", student.Subject.Years);

                long id = (long)command.ExecuteScalar();
                student.Id = (int)id;
                command.ExecuteNonQuery();
            }

        }

        public void deleteStudent(Student student)
        {
            const string query = "DELETE FROM Student WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", student.Id);

                command.ExecuteNonQuery();
            }
        }

    }
}
