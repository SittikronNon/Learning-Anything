using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace LinqAndSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            
            string connectionString = ConfigurationManager.ConnectionStrings["LinqAndSQL.Properties.Settings.SittikronDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversity();
            //InsertStudent();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniversityTony();

            //GetLecturesFromTony();
            //GetAllStudentsFromYale();
            GetAllUniversityWithFemale();
        }

        public void InsertUniversity()
        {
            dataContext.ExecuteCommand("delete from University");

            
            University yale = new University();
            University newcastle = new University();
            yale.Name = "Yale";
            newcastle.Name = "Newcastle";
            dataContext.Universities.InsertOnSubmit(yale);
            dataContext.Universities.InsertOnSubmit(newcastle);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudent()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University newcastle = dataContext.Universities.First(un => un.Name.Equals("Newcastle"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Nick", Gender = "Male", UniversityId = yale.Id });
            students.Add(new Student { Name = "Tony", Gender = "Male", UniversityId = newcastle.Id });
            students.Add(new Student { Name = "Minnie", Gender = "Female", University = yale});
            students.Add(new Student { Name = "Mind", Gender = "Female", University = newcastle });
            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;
        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "English" });

            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Lectures;

        }

        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Nick"));
            Student Tony = dataContext.Students.First(st => st.Name.Equals("Tony"));
            Student Minnie = dataContext.Students.First(st => st.Name.Equals("Minnie"));
            Student Mind = dataContext.Students.First(st => st.Name.Equals("Mind"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));
            Lecture English = dataContext.Lectures.First(lc => lc.Name.Equals("English"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Tony, Lecture = Math });

            StudentLecture slMind = new StudentLecture();
            slMind.Student = Mind;
            slMind.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slMind);
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Minnie, Lecture = English });
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.StudentLectures;
        }

        public void GetUniversityTony()
        {
            Student Tony = dataContext.Students.First(st => st.Name.Equals("Tony"));

            University TonyUniversity = Tony.University;

            List<University> universities = new List<University>();
            universities.Add(TonyUniversity);

            MainDataGrid.ItemsSource = universities;
        }

        public void GetLecturesFromTony()
        {
            Student Tony = dataContext.Students.First(st => st.Name.Equals("Tony"));
            var tonyLectures = from sl in Tony.StudentLectures select sl.Lecture;
            MainDataGrid.ItemsSource = tonyLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversityWithFemale()
        {
            var femaleUniversities = from student in dataContext.Students
                                          join university in dataContext.Universities
                                          on student.University equals university
                                          where student.Gender == "Female"
                                          select university;
            MainDataGrid.ItemsSource = femaleUniversities;
        }
    }
}
