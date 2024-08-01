using GradeManager;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeManagerWin
{
    public partial class GradeManagerWin : Form
    {
        List<Student> students;

        public GradeManagerWin()
        {
            InitializeComponent();
        }
        
        
        private void LoadStudentFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog LoadStudentFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"C:/",
                Title = "Load Student File",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "JSON files (*.json)|*.json)",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
            };

            if (LoadStudentFileDialog.ShowDialog() == DialogResult.OK)
            {

                var jsonFile = LoadStudentFileDialog.FileName;
                var json = File.ReadAllText(jsonFile);
                students = JsonConvert.DeserializeObject<List<Student>>(json);

                if (students != null)
                {
                    var message = $"Students loaded successfully. There are {students.Count} students currently.";
                    var caption = $"Students loaded successfully.";
                    MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                else
                {
                    var message = "Laoding of students failed!";
                    var caption = "Student Load Failed.";
                    MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                var message = "Laoding of students failed!";
                var caption = "Student Load Failed.";
                MessageBox.Show(message, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            var addStudentControl = new AddStudent();
            addStudentControl.Show();
            addStudentControl.Focus();
            var newStudentFirstname = addStudentControl.ReturnFirstName();
            var newStudentLastName = addStudentControl.ReturnLastName();
            var student = new Student(newStudentFirstname, newStudentLastName);
            students.Add(student);
            var messageBoxMessage = $"New Student {newStudentFirstname},{newStudentLastName} has been added.";
            var messageBoxCaption = $"New Student Added";

           // MessageBox.Show();
        }
        
    }
            
}
