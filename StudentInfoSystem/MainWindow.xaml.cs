using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> list;
        public Student student;

        public MainWindow()
        {
            InitializeComponent();
            FillStudStatusChoices();
            this.list = StudentData.TestStudents;
            foreach (Student element in list)
            {
                student = element;
                if (student != null)
                {
                    DisplayData(student);
                } else
                {
                    ClearAll();
                    DeactivateAll();
                }
            }
        }

        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            Style st = FindResource("styleA") as Style;
            MainGrid.Style = st;
        }

        private void rb2_Checked(object sender, RoutedEventArgs e)
        {
            Style st = FindResource("styleB") as Style;
            MainGrid.Style = st;
        }

        private void rb3_Checked(object sender, RoutedEventArgs e)
        {
            Style st = FindResource("styleC") as Style;
            MainGrid.Style = st;
        }

        public void ClearAll()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                   ((TextBox)item).Text = "";
                }
            }
        }

        public void DisplayData(Student student)
        {
            txtFirstName.Text = student.name;
            txtMiddleName.Text = student.middleName;
            txtLastName.Text = student.lastName;
            txtFac.Text = student.faculty;
            txtModule.Text = student.module;
            txtOKS.Text = student.degree;
            txtStatus.Text = student.status;
            txtFacNum.Text = student.facultyNum;
            txtCourse.Text = student.course.ToString();
            txtStream.Text = student.stream.ToString();
            txtGroup.Text = student.group.ToString();
        }

        public void DeactivateAll()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }
        public void ActivateAll()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }

        public List<string> StudStatusChoices { get; set; }

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery =
                @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)
                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }

    }
}
