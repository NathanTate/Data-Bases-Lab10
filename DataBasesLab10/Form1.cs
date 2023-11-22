using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBasesLab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ISubjectsDAO subjectsDAO = new SubjectsDAO();
            dataGridView1.DataSource = subjectsDAO.GetAllSubjects();
        }

        private void Load_Btn_Click(object sender, EventArgs e)
        {
            ISubjectsDAO subjectsDao = new SubjectsDAO();

            dataGridView1.DataSource = subjectsDao.GetAllSubjects();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            ISubjectsDAO subjectsDAO = new SubjectsDAO();
            Subjects subjects = new Subjects
            {
                Subject = Subject_Box.Text,
                Subject_Type = Subject_Type_Box.Text,
                Teacher = Teacher_Box.Text,
                Semester = TryParse(Semester_Box.Text, Semester_Box.Name),
                Hours = TryParse(Hours_Box.Text, Hours_Box.Name),
                Specialization = Specialization_Box.Text,
                Academic_Group = TryParse(Academic_Group_Box.Text, Academic_Group_Box.Name)
            };
            if (subjects.Semester != -1 && subjects.Hours != 1 && subjects.Academic_Group != -1)
            {
                MessageBox.Show($"{subjectsDAO.CreateSubject(subjects)} rows affected");
            }
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            ISubjectsDAO subjectsDAO = new SubjectsDAO();
            Subjects subjects = new Subjects
            {
                Id = Convert.ToInt16(TryParse(Update_Id_Box.Text, Update_Id_Box.Name)),
                Subject = Subject_Box.Text,
                Subject_Type = Subject_Type_Box.Text,
                Teacher = Teacher_Box.Text,
                Semester = TryParse(Semester_Box.Text, Semester_Box.Name),
                Hours = TryParse(Hours_Box.Text, Hours_Box.Name),
                Specialization = Specialization_Box.Text,
                Academic_Group = TryParse(Academic_Group_Box.Text, Academic_Group_Box.Name)
            };
            if (subjects.Semester != -1 && subjects.Hours != 1 && subjects.Academic_Group != -1 && subjects.Id != -1)
            {
                subjectsDAO.UpdateSubject(subjects);
                dataGridView1.DataSource = subjectsDAO.GetAllSubjects();
                MessageBox.Show($"Subject {subjects.Id} updated successfully");
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            ISubjectsDAO subjectsDAO = new SubjectsDAO();

            try
            {
                string selectedRow = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Ви впевнені, що хочете видали ці дані?", "Підтведження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show($"{subjectsDAO.DeleteSubject(TryParse(selectedRow, Search_Box.Name))} rows affected");
                    dataGridView1.DataSource = subjectsDAO.GetAllSubjects();
                }
            }
            catch
            {
                MessageBox.Show("Помилка при спробі видалення даних", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private int TryParse(string text, string name)
        {
            if(int.TryParse(text, out int result))
            {
                return result;
            }
            else 
            {
                MessageBox.Show($"{name} should be a number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SubjectsDAO subjectsDAO = new SubjectsDAO();
            int Id = TryParse(Search_Box.Text, Search_Box.Name);
            if (Id == -1) return;

            var subject = subjectsDAO.GetSubject(Id);

            if (subject == null)
            {
                MessageBox.Show("Предмету з таким ID не знайдено", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dataGridView1.DataSource = subject;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                Update_Id_Box.Text = selectedRow.Cells[0].Value.ToString();
                Subject_Box.Text = selectedRow.Cells[1].Value.ToString();
                Specialization_Box.Text = selectedRow.Cells[2].Value.ToString();
                Subject_Type_Box.Text = selectedRow.Cells[3].Value.ToString();
                Teacher_Box.Text = selectedRow.Cells[4].Value.ToString();
                Semester_Box.Text = selectedRow.Cells[5].Value.ToString();
                Hours_Box.Text = selectedRow.Cells[6].Value.ToString();
                Academic_Group_Box.Text = selectedRow.Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Id_Box.Text = string.Empty;
            Subject_Box.Text = string.Empty;
            Subject_Type_Box.Text = string.Empty;
            Teacher_Box.Text = string.Empty;
            Semester_Box.Text = string.Empty;
            Hours_Box.Text = string.Empty;
            Specialization_Box.Text = string.Empty;
            Academic_Group_Box.Text = string.Empty;
        }
    }
}
