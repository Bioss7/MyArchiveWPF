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
    public partial class AcademicVacationForm : Window
    {
        DbArchiveEntities db = new DbArchiveEntities();

        public AcademicVacationForm()
        {
            InitializeComponent();
           
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var groupStudent = db.GroupStudentNumber.ToList();
            var pesrons = db.Person.ToList();

            NumberGroupCB.ItemsSource = groupStudent;
            GridAcademic.ItemsSource = db.AcademicLeave.ToList();
            GridStudent.ItemsSource = db.Student.ToList();

        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            AcademicLeave academicLeave = new AcademicLeave()
            {               
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
            var queryRemove = db.AcademicLeave.Where(d => d.AcademicLeaveId == num).FirstOrDefault();
            db.AcademicLeave.Remove(queryRemove);
            db.SaveChanges();
            GridAcademic.ItemsSource = db.AcademicLeave.ToList();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            int num = (GridAcademic.SelectedItem as AcademicLeave).AcademicLeaveId;
            var queryUpdate = db.AcademicLeave.Where(u => u.AcademicLeaveId == num).FirstOrDefault();
            AcademicLeave academicLeave = new AcademicLeave();
            queryUpdate.IdStudent = Convert.ToInt32(StudentTb.Text);
            queryUpdate.DateAcademicLeave = Convert.ToDateTime(DateAcademicLeaveDP.SelectedDate);
            queryUpdate.OrderNumber = Convert.ToInt32(OrderNumberTB.Text);
            queryUpdate.DateExpiration = Convert.ToDateTime(DateExpirationDP.SelectedDate);
            queryUpdate.IdNumberGroup = Convert.ToInt32(NumberGroupCB.SelectedValue);
            db.SaveChanges();
            GridAcademic.ItemsSource = db.AcademicLeave.ToList();
        }
    }
}
