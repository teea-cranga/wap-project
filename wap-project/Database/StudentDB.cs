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
        private void addStudent(Student student)
        {
            var query = "insert into Student(FirstName, LastName, SubjectName, SubjectYears)" +
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
                //Year.students.Add(student);
            }
        }

        private void loadStudents()
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
                    }
                }
            }
        }

        private void deleteStudent(Student student)
        {
            const string query = "DELETE FROM Student WHERE Id=@id";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", student.Id);

                command.ExecuteNonQuery();

                //Year.students.Remove(student);
            }
        }

    }
}
