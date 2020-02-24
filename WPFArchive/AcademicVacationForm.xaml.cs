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
    /// Логика взаимодействия для AcademicVacationForm.xaml
    /// </summary>
    public partial class AcademicVacationForm : Window
    {
        DbArchiveEntities db;

        public AcademicVacationForm()
        {
            InitializeComponent();
            db = new DbArchiveEntities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var groupStudent = db.GroupStudentNumber.ToList();
            NumberGroupCB.ItemsSource = groupStudent;

            GridAcademic.ItemsSource = db.AcademicLeave.ToList();
            GridStudent.ItemsSource = db.Student.ToList();


            var pesron = db.Person.ToList();           
            PersonCB.ItemsSource = pesron;

            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AcademicLeave academicLeave = new AcademicLeave()
            {
                //IdStudent = Convert.ToInt32(PersonCB.SelectedValue),
                IdStudent = Convert.ToInt32(StudentTb.Text),
                DateAcademicLeave = Convert.ToDateTime(DateAcademicLeaveDP.SelectedDate),
                OrderNumber = Convert.ToInt32(OrderNumberTB.Text),
                DateExpiration = Convert.ToDateTime(DateExpirationDP.SelectedDate),
                IdNumberGroup = Convert.ToInt32(NumberGroupCB.SelectedValue)
            };

            db.AcademicLeave.Add(academicLeave);
            db.SaveChanges();
            GridAcademic.ItemsSource = db.AcademicLeave.ToList();
        }

        private void Button_ClickRemove(object sender, RoutedEventArgs e)
        {
            int num = (GridAcademic.SelectedItem as AcademicLeave).AcademicLeaveId;
            var idRow = db.AcademicLeave.Where(d => d.AcademicLeaveId == num).FirstOrDefault();
            db.AcademicLeave.Remove(idRow);

            GridAcademic.ItemsSource = db.AcademicLeave.ToList();
        }
    }
}
