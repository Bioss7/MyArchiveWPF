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
            GridStudentExpelled.ItemsSource = db.Student.ToList();
            GridFired.ItemsSource = db.Employee.ToList();

            GroupCB.ItemsSource = db.GroupStudentNumber.ToList();
           
            var groupStudent = db.GroupStudentNumber.ToList();
            GroupCB.ItemsSource = groupStudent;
            GroupCbe.ItemsSource = db.GroupStudentNumber.ToList();


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
                diploma.IdQualification = Convert.ToInt32(QualificationCB.SelectedValue);
                diploma.IdSpecialty = Convert.ToInt32(SpecialtyCB.SelectedValue);
                diploma.ApplicationSeries = Convert.ToInt32(ApplicationSeriesTB.Text);
                diploma.ApplicationNumber = Convert.ToInt32(ApplicationNumberTB.Text);
                diploma.ApplicationDate = Convert.ToDateTime(ApplicationDateDP.SelectedDate);
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
            var queryUpdate1 = db.Diploma.Where(u => u.Student.StudentId == num).FirstOrDefault();


            Student student = new Student();
            PersonalDocument personalDocument = new PersonalDocument();
            Person person = new Person();
            Diploma diploma = new Diploma();
            
            queryUpdate.Person.PersonalDocument.NumberPersonalDocument = NumberPersonalDocumentTB.Text;
            queryUpdate.Person.PersonalDocument.NumberInventory = NumberInventoryTB.Text;
            queryUpdate.Person.PersonalDocument.ShelfLife = Convert.ToInt16(ShelfLifeTB.Text);
            
            queryUpdate.Person.Lastname = LastNameTB.Text;
            queryUpdate.Person.Firstname = FirstTB.Text;
            queryUpdate.Person.Middlename = MiddleNameTB.Text;
            queryUpdate.Person.DateofBirth = Convert.ToDateTime(DateofBirthDP.SelectedDate);
           
            queryUpdate.NumberGroup = Convert.ToInt32(GroupCB.SelectedValue);             
                       
            queryUpdate1.Series = Convert.ToInt32(SeriesTB.Text);
            queryUpdate1.Number = Convert.ToInt32(NumberTB.Text);
            queryUpdate1.RegistrationNumber = Convert.ToInt32(RegistrationNumberTB.Text);
            queryUpdate1.IdQualification = Convert.ToInt32(QualificationCB.SelectedValue);
            queryUpdate1.IdSpecialty = Convert.ToInt32(SpecialtyCB.SelectedValue);
            queryUpdate1.ApplicationSeries = Convert.ToInt32(ApplicationSeriesTB.Text);
            queryUpdate1.ApplicationNumber = Convert.ToInt32(ApplicationNumberTB.Text);
            queryUpdate1.ApplicationDate = Convert.ToDateTime(ApplicationDateDP.SelectedDate);
            queryUpdate1.EnrollmentNumber = Convert.ToInt32(EnrollmentNumberTB.Text);
            queryUpdate1.EnrollmentDate = Convert.ToDateTime(EnrollmentDateDP.SelectedDate);
            queryUpdate1.ReleaseNumber = Convert.ToInt32(ReleaseNumberTB.Text);
            queryUpdate1.ReleaseDate = Convert.ToDateTime(ReleaseDate.SelectedDate);
               
            db.SaveChanges();
            GridStudents.ItemsSource = db.Student.ToList();
        }

        private void StudentDelBtn_Click(object sender, RoutedEventArgs e)
        {
            int num = (GridStudents.SelectedItem as Student).StudentId;

            var queryDel = db.Student.Where(d => d.StudentId == num).FirstOrDefault();
            db.Student.Remove(queryDel);
            db.SaveChanges();
            GridStudents.ItemsSource = db.Student.ToList();
        }

        private void StudentAddBtnExpelled_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            PersonalDocument personalDocument = new PersonalDocument();

            if (personalDocument != null)
            {
                personalDocument.NumberPersonalDocument = NumberPersonalDocumentTBe.Text;
                personalDocument.NumberInventory = NumberInventoryTBe.Text;
                personalDocument.ShelfLife = Convert.ToInt16(ShelfLifeTBe.Text);

                db.PersonalDocument.Add(personalDocument);
                db.SaveChanges();
            }



            if (person != null)
            {
                person.Lastname = LastNameTBe.Text;
                person.Firstname = FirstTBe.Text;
                person.Middlename = MiddleNameTBe.Text;
                person.DateofBirth = Convert.ToDateTime(DateofBirthDPe.SelectedDate);
                person.IdPersonalDocument = personalDocument.PersonalDocumentId;


                db.Person.Add(person);
                db.SaveChanges();

            }

            Student student = new Student();
            GroupStudentNumber groupStudentNumber = new GroupStudentNumber();          

            if (student != null)
            {
                student.IdPerson = person.PersonId;               
                student.EnrollmentNumber = Convert.ToInt32(EnrollmentNumberTb.Text);
                student.EnrollmentDate = Convert.ToDateTime(EnrollmentDateDp.SelectedDate);
                student.NumberGroup = Convert.ToInt32(GroupCbe.SelectedValue);
                student.DeductionNumber = Convert.ToInt32(DeductionNumberTb.Text);
                student.DeductionDate = Convert.ToDateTime(DeductionDateDp.SelectedDate);
                student.Reasonfordeduction = ReasonfordeductionTb.Text;

                db.Student.Add(student);
                db.SaveChanges();

            }

            GridStudentExpelled.ItemsSource = db.Student.ToList();

        }

        private void StudentAddUpdExpelled_Click(object sender, RoutedEventArgs e)
        {
            int num = (GridStudentExpelled.SelectedItem as Student).StudentId;
            var queryUpdate = db.Student.Where(u => u.StudentId == num).FirstOrDefault();

            Person person = new Person();
            PersonalDocument personalDocument = new PersonalDocument();

            if (personalDocument != null)
            {
                queryUpdate.Person.PersonalDocument.NumberPersonalDocument = NumberPersonalDocumentTBe.Text;
                queryUpdate.Person.PersonalDocument.NumberInventory = NumberInventoryTBe.Text;
                queryUpdate.Person.PersonalDocument.ShelfLife = Convert.ToInt16(ShelfLifeTBe.Text);

                //db.PersonalDocument.Add(personalDocument);
                //db.SaveChanges();
            }



            if (person != null)
            {
                queryUpdate.Person.Lastname = LastNameTBe.Text;
                queryUpdate.Person.Firstname = FirstTBe.Text;
                queryUpdate.Person.Middlename = MiddleNameTBe.Text;
                queryUpdate.Person.DateofBirth = Convert.ToDateTime(DateofBirthDPe.SelectedDate);
                //queryUpdate.Person.IdPersonalDocument = personalDocument.PersonalDocumentId;


                //db.Person.Add(person);
                //db.SaveChanges();

            }

            Student student = new Student();
            GroupStudentNumber groupStudentNumber = new GroupStudentNumber();

            if (student != null)
            {
                //student.IdPerson = person.PersonId;
                queryUpdate.EnrollmentNumber = Convert.ToInt32(EnrollmentNumberTb.Text);
                queryUpdate.EnrollmentDate = Convert.ToDateTime(EnrollmentDateDp.SelectedDate);
                queryUpdate.NumberGroup = Convert.ToInt32(GroupCbe.SelectedValue);
                queryUpdate.DeductionNumber = Convert.ToInt32(DeductionNumberTb.Text);
                queryUpdate.DeductionDate = Convert.ToDateTime(DeductionDateDp.SelectedDate);
                queryUpdate.Reasonfordeduction = ReasonfordeductionTb.Text;

                //db.Student.Add(student);
                //db.SaveChanges();

            }

            
            db.SaveChanges();
            GridStudentExpelled.ItemsSource = db.Student.ToList();

        }

        private void StudentAddDelExpelled_Click(object sender, RoutedEventArgs e)
        {
            int num = (GridStudentExpelled.SelectedItem as Student).StudentId;
            var queryDel = db.Student.Where(d => d.StudentId == num).FirstOrDefault();
            db.Student.Remove(queryDel);
            db.SaveChanges();
            GridStudentExpelled.ItemsSource = db.Student.ToList();
        }

        private void EmployeeAddBtn_Click(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            PersonalDocument personalDocument = new PersonalDocument();

            if (personalDocument != null)
            {
                personalDocument.NumberPersonalDocument = NumberPersonalDocumentEmployeeTB.Text;
                personalDocument.NumberInventory = NumberInventoryEmployeeTB.Text;
                personalDocument.ShelfLife = Convert.ToInt16(ShelfLifeEmployeeTB.Text);

                db.PersonalDocument.Add(personalDocument);
                db.SaveChanges();
            }



            if (person != null)
            {
                person.Lastname = LastNameEmployeeTb.Text;
                person.Firstname = FirstEmployeeTb.Text;
                person.Middlename = MiddleNameEmployeeTB.Text;
                person.DateofBirth = Convert.ToDateTime(DateofBirthEmployeeDP.SelectedDate);
                person.IdPersonalDocument = personalDocument.PersonalDocumentId;


                db.Person.Add(person);
                db.SaveChanges();

            }

            Employee employee = new Employee();
            if (employee != null)
            {
                employee.IdPerson = person.PersonId;
                employee.NumberReception = Convert.ToInt32(NumberReceptionTB.Text);
                employee.DateReception = Convert.ToDateTime(DateReceptionDP.SelectedDate);
                employee.Position = PositionTB.Text;
                employee.NumberFired = Convert.ToInt32(NumberFiredTB.Text);
                employee.DateFired = DateFiredDP.SelectedDate;
                employee.СauseFired = СauseFired.Text;
            }

            db.SaveChanges();
            db.Employee.Add(employee);
            GridFired.ItemsSource = db.Employee.ToList();
        }

        private void EmployeeUpdBtn_Click(object sender, RoutedEventArgs e)
        {
            int num = (GridFired.SelectedItem as Employee).EmployeeId;
            var queryUpdate = db.Employee.Where(u => u.EmployeeId == num).FirstOrDefault();

            Person person = new Person();
            PersonalDocument personalDocument = new PersonalDocument();

            if (personalDocument != null)
            {
               queryUpdate.Person.PersonalDocument.NumberPersonalDocument = NumberPersonalDocumentEmployeeTB.Text;
               queryUpdate.Person.PersonalDocument.NumberInventory = NumberInventoryEmployeeTB.Text;
               queryUpdate.Person.PersonalDocument.ShelfLife = Convert.ToInt16(ShelfLifeEmployeeTB.Text);

                //db.PersonalDocument.Add(personalDocument);
                //db.SaveChanges();
            }



            if (person != null)
            {
                queryUpdate.Person.Lastname = LastNameEmployeeTb.Text;
                queryUpdate.Person.Firstname = FirstEmployeeTb.Text;
                queryUpdate.Person.Middlename = MiddleNameEmployeeTB.Text;
                queryUpdate.Person.DateofBirth = Convert.ToDateTime(DateofBirthEmployeeDP.SelectedDate);
                //person.IdPersonalDocument = personalDocument.PersonalDocumentId;


                //db.Person.Add(person);
                //db.SaveChanges();

            }

            Employee employee = new Employee();
            if (employee != null)
            {
                //employee.IdPerson = person.PersonId;
                queryUpdate.NumberReception = Convert.ToInt32(NumberReceptionTB.Text);
                queryUpdate.DateReception = Convert.ToDateTime(DateReceptionDP.SelectedDate);
                queryUpdate.Position = PositionTB.Text;
                queryUpdate.NumberFired = Convert.ToInt32(NumberFiredTB.Text);
                queryUpdate.DateFired = DateFiredDP.SelectedDate;
                queryUpdate.СauseFired = СauseFired.Text;
            }

            db.SaveChanges();            
            GridFired.ItemsSource = db.Employee.ToList();
        }

        private void EmployeeDelBtn_Click(object sender, RoutedEventArgs e)
        {
            int num = (GridFired.SelectedItem as Employee).EmployeeId;
            var queryDel = db.Employee.Where(u => u.EmployeeId == num).FirstOrDefault();
            db.Employee.Remove(queryDel);
            db.SaveChanges();
            GridFired.ItemsSource = db.Employee.ToList();

        }

        private void TEST(object sender, RoutedEventArgs e)
        {
            string searh = searhtx.Text;
            var query = db.Student.ToList().Where(x => x.Person.Firstname.Contains(searh) || x.Person.Lastname.Contains(searh) || x.Person.Middlename.Contains(searh)).ToList();

            GridStudents.ItemsSource = query.ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
           
            //var query = db.Student.ToList().Where(x => x.Person.Firstname.StartsWith(SearchTb.Text) || x.Person.Lastname.StartsWith(SearchTb.Text) || x.Person.Middlename.StartsWith(SearchTb.Text)).ToList();
            var querySearch = db.Student.ToList().Where(x => (x.Person.Firstname + " " + x.Person.Lastname + " " + x.Person.Middlename + " " + x.GroupStudentNumber.NumberGroup).ToLower()
            .Contains(SearchTb.Text.ToLower()))
            .ToList();

            GridStudents.ItemsSource = querySearch.ToList();
        }

        private void SearcheExpelledStudent_Click(object sender, RoutedEventArgs e)
        {          
            var querySearch = db.Student.ToList().Where(x => (x.Person.Firstname + " " + x.Person.Lastname + " " + x.Person.Middlename + " " + x.GroupStudentNumber.NumberGroup).ToLower()
           .Contains(SearchTbe.Text.ToLower()))
           .ToList();

            
            GridStudentExpelled.ItemsSource = querySearch.ToList();
        }
      
        private void SearcheStudentFired_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
