﻿using System;
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
    public partial class Main : Window
    {
        DbArchiveEntities db = new DbArchiveEntities();
        public int GetOrderPerson;

        public Main()
        {
            InitializeComponent();
                   
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var groupStudent = db.GroupStudentNumber.ToList();
            GroupCB.ItemsSource = groupStudent;
            GroupCb.ItemsSource = groupStudent;
            QualificationCB.ItemsSource = db.Qualification.ToList();
            SpecialtyCB.ItemsSource = db.Specialty.ToList();
            CbSpec.ItemsSource = db.Specialty.ToList();


        }
       

        private void Button_ClickAddData(object sender, RoutedEventArgs e)
        {
            Person person = new Person();
            PersonalDocument personalDocument = new PersonalDocument();
            OrderList orderList = new OrderList();

            try
            {
                if (personalDocument != null)
                {

                    // Приказ
                    //personalDocument.DateOrder = DpDateOrder.SelectedDate;
                    //personalDocument.NumberOrder = TbNumberOrder.Text;
                    //personalDocument.TitleOrder = TbNumberOrder.Text;
                    ///



                    personalDocument.NumberPersonalDocument = NumberPersonalDocumentTB.Text;
                    personalDocument.NumberInventory = NumberInventoryTB.Text;
                    personalDocument.ShelfLife = Convert.ToInt16(ShelfLifeTB.Text);

                    db.PersonalDocument.Add(personalDocument);
                    //db.OrderList.Add(orderList);
                    db.SaveChanges();
                }



                if (person != null)
                {
                    person.Lastname = LastNameTB.Text;
                    person.Firstname = FirstTB.Text;
                    person.Middlename = MiddleNameTB.Text;
                    person.DateofBirth = Convert.ToDateTime(DateofBirthDP.SelectedDate);
                    person.IdPersonalDocument = personalDocument.PersonalDocumentId;
                    person.Аddress = TbAdress.Text;
                    person.NumberPhone = TbNumberPhone.Text;

                    //person.IdOrderList = orderList.IdOrderList;




                    db.Person.Add(person);
                    db.SaveChanges();

                    orderList.IdPerson = person.PersonId;
                    orderList.DateOrder = DpDateOrder.SelectedDate;
                    orderList.NumberOrder = TbNumberOrder.Text;
                    orderList.TitleOrder = TbTitleOrder.Text;

                    db.OrderList.Add(orderList);
                    db.SaveChanges();
                    GetOrderPerson = person.PersonId;
                }

                MessageBox.Show("Добавлен!");
            }
            catch (Exception)
            {
                MessageBox.Show("Поля не заполнены или введены некорректные данные!");
                
            }

            

            // Добавление студента выпускника
            if (check1.IsChecked == true)
            {
                GroupCB.ItemsSource = db.GroupStudentNumber.ToList();
                Student student = new Student();
                GroupStudentNumber groupStudentNumber = new GroupStudentNumber();
                Diploma diploma = new Diploma();
                GroupStudentNumber groupStudent = new GroupStudentNumber();

                if (student != null)
                {
                    student.IdPerson = person.PersonId;
                    student.NumberGroup = Convert.ToInt32(GroupCB.SelectedValue);
                    student.GradebookNumber = TbGradebookNumber.Text;


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
                    //diploma.EnrollmentNumber = Convert.ToInt32(EnrollmentNumberTB.Text);
                    //diploma.EnrollmentDate = Convert.ToDateTime(EnrollmentDateDP.SelectedDate);
                    //diploma.ReleaseNumber = Convert.ToInt32(ReleaseNumberTB.Text);
                    //diploma.ReleaseDate = Convert.ToDateTime(ReleaseDate.SelectedDate);
                    diploma.NameEducational = TbNameEducational.Text;

                    db.Diploma.Add(diploma);
                    db.SaveChanges();

                }




            }
            // Добавление отчисленного
            if (check2.IsChecked == true)
            {
                try
                {
                    Student student = new Student()
                    {
                        IdPerson = person.PersonId,
                        //EnrollmentNumber = Convert.ToInt32(EnrollmentNumberTb.Text),
                        //EnrollmentDate = Convert.ToDateTime(EnrollmentDateDp.SelectedDate),
                        //DeductionNumber = Convert.ToInt32(DeductionNumberTb.Text),
                        //DeductionDate = Convert.ToDateTime(DeductionDateDp.SelectedDate),
                        //Reasonfordeduction = ReasonfordeductionTb.Text,
                        NumberGroup = Convert.ToInt32(GroupCb.SelectedValue)
                    };

                    db.Student.Add(student);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Поля не заполнены или введены некорректные данные!");
                }
               
            }
            // Добавление сотрудники
            if (check3.IsChecked == true)
            {
                Employee employee = new Employee()
                {
                    IdPerson = person.PersonId,
                    //NumberReception = Convert.ToInt32(NumberReceptionTB.Text),
                    //DateReception = Convert.ToDateTime(DateReceptionDP.SelectedDate),
                    Position = PositionTB.Text,
                    //NumberFired = Convert.ToInt32(NumberFiredTB.Text),
                    //DateFired = Convert.ToDateTime(DateFiredDP.SelectedDate),
                    //СauseFired = СauseFired.Text,
                    PersonalNumber = TbPersonalNumber.Text
                    
                };

                db.Employee.Add(employee);
                db.SaveChanges();
            }
    }

        private void CheckVacation1_Click(object sender, RoutedEventArgs e)
        {
            AcademicVacationForm academicVacationForm = new AcademicVacationForm();
            academicVacationForm.ShowDialog();
        }

        private void CheckVacation2_Click(object sender, RoutedEventArgs e)
        {
            AcademicVacationForm academicVacationForm = new AcademicVacationForm();
            academicVacationForm.ShowDialog();
        }

        private void DisciplineBtnAdd_Click(object sender, RoutedEventArgs e)
        {
            DisciplineWindow disciplineWindow = new DisciplineWindow();
            disciplineWindow.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) // Настройки
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            settingsWindow.Show();
        }

        private void SearchBtn(object sender, RoutedEventArgs e)
        {
            TableWindow tableWindow = new TableWindow();
            tableWindow.ShowDialog();
        }

        private void ReportsBtn(object sender, RoutedEventArgs e)
        {
            ReportsWindow reportsWindow = new ReportsWindow();
            reportsWindow.Show();
        }

        private void ActsBtn(object sender, RoutedEventArgs e)
        {
            ActsWindow actsWindow = new ActsWindow();
            actsWindow.Show();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) // Для отчества
        {
            
        }

        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow(GetOrderPerson);
            orderWindow.Show();
                

            //OrderList orderList = new OrderList();

            //orderList.DateOrder = DpDateOrder.SelectedDate;
            //orderList.NumberOrder = TbNumberOrder.Text;
            //orderList.TitleOrder = TbNumberOrder.Text;
            //db.OrderList.Add(orderList);
        }

        private void BtnOrder(object sender, RoutedEventArgs e)
        {
            OrderWindow orderWindow = new OrderWindow(0);
            orderWindow.Show();
        }

        private void check3_Checked(object sender, RoutedEventArgs e)
        {
            //if(check3.IsChecked == true)
            //{
            //    DisciplineBtnAdd.IsEnabled = false;
            //}
            //else
            //{
            //    DisciplineBtnAdd.IsEnabled = true;
            //}

        }

        private void check1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void check3_Click(object sender, RoutedEventArgs e)
        {
            if (check3.IsChecked == true)
            {
                DisciplineBtnAdd.Visibility = Visibility.Collapsed;
            }
            else
            {
                DisciplineBtnAdd.Visibility = Visibility.Visible;
            }
        }

        //private void BtnClear(object sender, RoutedEventArgs e)
        //{

        //}
        private void BtnClear(object sender, RoutedEventArgs e)
        {
            ClearsElement();
        }

        void ClearsElement()
        {
            LastNameTB.Text = string.Empty;
            FirstTB.Text = string.Empty;
            MiddleNameTB.Text = string.Empty;
            DateofBirthDP.SelectedDate = null;
            TbAdress.Text = string.Empty;
            TbNumberPhone.Text = string.Empty;
            NumberPersonalDocumentTB.Text = string.Empty;
            NumberInventoryTB.Text = string.Empty;
            ShelfLifeTB.Text = string.Empty;
            DpDateOrder.SelectedDate = null;
            TbNumberOrder.Text = string.Empty;
            TbTitleOrder.Text = string.Empty;
            check1.IsChecked = false;
            check2.IsChecked = false;
            check3.IsChecked = false;
        }

        

    }
}
