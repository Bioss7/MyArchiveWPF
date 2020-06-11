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
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        DbArchiveEntities db = new DbArchiveEntities();

        public SettingsWindow()
        {
            InitializeComponent();


            DgGroup.ItemsSource = db.GroupStudentNumber.ToList();
            DgQ.ItemsSource = db.Qualification.ToList();
            DgS.ItemsSource = db.Specialty.ToList();
        }

        private void BtnGroupAdd_Click(object sender, RoutedEventArgs e)
        {
            GroupStudentNumber groupStudentNumber = new GroupStudentNumber()
            {
                NumberGroup = TbGroup.Text
            };
            db.GroupStudentNumber.Add(groupStudentNumber);
            db.SaveChanges();
            DgGroup.ItemsSource = db.GroupStudentNumber.ToList();

        }

        private void BtnGroupDel_Click(object sender, RoutedEventArgs e)
        {
            int num = (DgGroup.SelectedItem as GroupStudentNumber).GroupStudentNumberId;
            var q = db.GroupStudentNumber.Where(d => d.GroupStudentNumberId == num).FirstOrDefault();
            db.GroupStudentNumber.Remove(q);
            db.SaveChanges();
            DgGroup.ItemsSource = db.GroupStudentNumber.ToList();
        }

        private void BtnQAdd_Click(object sender, RoutedEventArgs e)
        {
            Qualification qualification = new Qualification()
            {
                NameQualification = TbQ.Text
            };
            db.Qualification.Add(qualification);
            db.SaveChanges();
            DgQ.ItemsSource = db.Qualification.ToList();
        }

        private void BtnQDel_Click(object sender, RoutedEventArgs e)
        {
            int num = (DgQ.SelectedItem as Qualification).QualificationId;
            var q = db.Qualification.Where(d => d.QualificationId == num).FirstOrDefault();
            db.Qualification.Remove(q);
            db.SaveChanges();
            DgQ.ItemsSource = db.Qualification.ToList();
        }

        private void BtnAddS_Click(object sender, RoutedEventArgs e)
        {
            Specialty specialty = new Specialty()
            {
                SpecialtyName = TbS.Text
            };
            db.Specialty.Add(specialty);
            db.SaveChanges();
            DgS.ItemsSource = db.Specialty.ToList();

        }

        private void BtnADelS_Click(object sender, RoutedEventArgs e)
        {
            int num = (DgS.SelectedItem as Specialty).SpecialtyId;
            var q = db.Specialty.Where(d => d.SpecialtyId == num).FirstOrDefault();
            db.Specialty.Remove(q);
            db.SaveChanges();
            DgS.ItemsSource = db.Specialty.ToList();
        }
    }
}
