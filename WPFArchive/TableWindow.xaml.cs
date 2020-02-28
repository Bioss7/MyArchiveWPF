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
using System.Windows.Shapes;

namespace WPFArchive
{
    /// <summary>
    /// Логика взаимодействия для TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        DbArchiveEntities db;

        public TableWindow()
        {
            InitializeComponent();
            db = new DbArchiveEntities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {           
            GridStudents.ItemsSource = db.Student.ToList();

            GroupCB.ItemsSource = db.GroupStudentNumber.ToList();

            // 
            var groupStudent = db.GroupStudentNumber.ToList();
            GroupCB.ItemsSource = groupStudent;
            

            QualificationCB.ItemsSource = db.Qualification.ToList();
            SpecialtyCB.ItemsSource = db.Specialty.ToList();
        }

        private void StudentAddBtn_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            PersonalDocument personalDocument = new PersonalDocument();

            if (personalDocument != null)
            {
                personalDocument.NumberPersonalDocument = NumberPersonalDocumentTB.Text;
                personalDocument.NumberInventory = NumberInventoryTB.Text;
                personalDocument.ShelfLife = Convert.ToInt16(ShelfLifeTB.Text);

                db.PersonalDocument.Add(personalDocument);
                db.SaveChanges();
            }



            if (person != null)
            {
                person.Lastname = LastNameTB.Text;
                person.Firstname = FirstTB.Text;
                person.Middlename = MiddleNameTB.Text;
                person.DateofBirth = Convert.ToDateTime(DateofBirthDP.SelectedDate);
                person.IdPersonalDocument = personalDocument.PersonalDocumentId;


                db.Person.Add(person);
                db.SaveChanges();

            }

            GroupCB.ItemsSource = db.GroupStudentNumber.ToList();
            Student student = new Student();
            GroupStudentNumber groupStudentNumber = new GroupStudentNumber();
            Diploma diploma = new Diploma();
            GroupStudentNumber groupStudent = new GroupStudentNumber();

            if (student != null)
            {
                student.IdPerson = person.PersonId;
                student.NumberGroup = Convert.ToInt32(GroupCB.SelectedValue);


                db.Student.Add(student);
                db.SaveChanges();

            }

            if (diploma != null)
            {
                diploma.IdStudent = student.StudentId;
                diploma.Series = Convert.ToInt32(SeriesTB.Text);
                diploma.Number = Convert.ToInt32(NumberTB.Text);
                diploma.RegistrationNumber = Convert.ToInt32(RegistrationNumberTB.Text);
                diploma.IdQualification = Convert.ToInt32(GroupCB.SelectedValue);
                diploma.IdSpecialty = Convert.ToInt32(SpecialtyCB.SelectedValue);
                diploma.ApplicationSeries = Convert.ToInt32(ApplicationSeriesTB.Text);
                diploma.ApplicationNumber = Convert.ToInt32(ApplicationNumberTB.Text);
                diploma.EnrollmentNumber = Convert.ToInt32(EnrollmentNumberTB.Text);
                diploma.EnrollmentDate = Convert.ToDateTime(EnrollmentDateDP.SelectedDate);
                diploma.ReleaseNumber = Convert.ToInt32(ReleaseNumberTB.Text);
                diploma.ReleaseDate = Convert.ToDateTime(ReleaseDate.SelectedDate);

                db.Diploma.Add(diploma);
                db.SaveChanges();

            }
            MessageBox.Show("Выпускник добавлен");
            GridStudents.ItemsSource = db.Student.ToList();
        }

        private void CheckVacationAddTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DisciplineBtnAddTable_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StudentUpdBtn_Click(object sender, RoutedEventArgs e)
        {
            int num = (GridStudents.SelectedItem as Student).StudentId;
            var queryUpdate = db.Student.Where(u => u.StudentId == num).FirstOrDefault();

            Student student = new Student();

            //queryUpdate.StudentId = Convert.ToInt32(StudentTb.Text);

            queryUpdate.Person.Lastname = LastNameTB.Text;
            queryUpdate.Person.Firstname = FirstTB.Text;
            queryUpdate.Person.Middlename = MiddleNameTB.Text;
            queryUpdate.Person.DateofBirth = Convert.ToDateTime(DateofBirthDP.SelectedDate);

            GridStudents.ItemsSource = db.Student.ToList();
        }
    }
}
