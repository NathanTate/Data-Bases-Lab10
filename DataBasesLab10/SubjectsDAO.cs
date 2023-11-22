using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBasesLab10
{
    public class SubjectsDAO : ISubjectsDAO
    {
        private readonly MySqlConnection _connection;
        private readonly MySqlCommand _command;
        public SubjectsDAO() 
        {
            try
            {
                _connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["tateDb"].ConnectionString);
                _connection.Open();
                _command = new MySqlCommand();
                _command.Connection = _connection;              
            }
            catch 
            {
                MessageBox.Show("Помилка підключення до бази даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int CreateSubject(Subjects subject)
        {
            int rowsAffected;
            try
            {
                _command.CommandText = "INSERT INTO subjects (subject, subject_type, teacher, semester, hours, specialization, academic_group) VALUES (@subject, @subject_type, @teacher, @semester, @hours, @specialization, @academic_group)";
                _command.Parameters.AddWithValue("@subject", subject.Subject);
                _command.Parameters.AddWithValue("@subject_type", subject.Subject_Type);
                _command.Parameters.AddWithValue("@teacher", subject.Teacher);
                _command.Parameters.AddWithValue("@semester", subject.Semester);
                _command.Parameters.AddWithValue("@hours", subject.Hours);
                _command.Parameters.AddWithValue("@specialization", subject.Specialization);
                _command.Parameters.AddWithValue("@academic_group", subject.Academic_Group);

                rowsAffected = _command.ExecuteNonQuery();
            }
            catch 
            {
                MessageBox.Show("Error creating subject", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            return rowsAffected;
        }

        public int DeleteSubject(int id)
        {
            try
            {
                _command.CommandText = "SELECT MAX(Id) FROM subjects";
                _command.CommandText = "DELETE FROM subjects WHERE Id = @Id";
                _command.Parameters.AddWithValue("@Id", id);
                return _command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Проблема при видаленні об'єкту", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return 0;
            }
        }

        public List<Subjects> GetAllSubjects()
        {
            List<Subjects> subjects = new List<Subjects>();

            _command.CommandText = "SELECT * FROM subjects";
            try
            {
                using (MySqlDataReader reader = _command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Subjects subject = new Subjects
                        {
                            Id = reader.GetInt16(0),
                            Subject = reader.GetString(1),
                            Subject_Type = reader.GetString(2),
                            Teacher = reader.GetString(3),
                            Semester = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                            Hours = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                            Specialization = reader.GetString(6),
                            Academic_Group = reader.IsDBNull(7) ? 0 : reader.GetInt32(7)
                        };

                        subjects.Add(subject);
                    }
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return subjects;
        }

        public List<Subjects> GetSubject(int id)
        {
            List<Subjects> subjects = new List<Subjects>();
            _command.CommandText = "SELECT * FROM subjects WHERE Id = @search";
            _command.Parameters.AddWithValue("@search", id);
            try
            {
                using(MySqlDataReader reader = _command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Subjects subject = new Subjects
                        {
                            Id = reader.GetInt16(0),
                            Subject = reader.GetString(1),
                            Subject_Type = reader.GetString(2),
                            Teacher = reader.GetString(3),
                            Semester = reader.IsDBNull(4) ? 0 : reader.GetInt32(4),
                            Hours = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                            Specialization = reader.GetString(6),
                            Academic_Group = reader.IsDBNull(7) ? 0 : reader.GetInt32(7)
                        };

                        subjects.Add(subject);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error");
            }

            return subjects;
        }

        public void UpdateSubject(Subjects subject)
        {
            try
            {
                _command.CommandText = "UPDATE subjects SET subject = @subject, subject_type = @subject_type, teacher = @teacher, semester = @semester, hours = @hours, specialization = @specialization, academic_group = @academic_group WHERE Id = @id";

                _command.Parameters.AddWithValue("@subject", subject.Subject);
                _command.Parameters.AddWithValue("@subject_type", subject.Subject_Type);
                _command.Parameters.AddWithValue("@teacher", subject.Teacher);
                _command.Parameters.AddWithValue("@semester", subject.Semester);
                _command.Parameters.AddWithValue("@hours", subject.Hours);
                _command.Parameters.AddWithValue("@specialization", subject.Specialization);
                _command.Parameters.AddWithValue("@academic_group", subject.Academic_Group);
                _command.Parameters.AddWithValue("@id", subject.Id);

                _command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Помилка при оновленні предмета", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
