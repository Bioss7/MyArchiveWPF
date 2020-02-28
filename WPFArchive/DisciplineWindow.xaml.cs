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
    /// Логика взаимодействия для DisciplineWindow.xaml
    /// </summary>
    public partial class DisciplineWindow : Window
    {
        DbArchiveEntities db;

        public DisciplineWindow()
        {
            InitializeComponent();
            db = new DbArchiveEntities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GridDiscipline.ItemsSource = db.Discipline.ToList();
            GridStudent.ItemsSource = db.Student.ToList();
            DisciplineListCB.ItemsSource = db.DisciplineList.ToList();
        }

        private void Button_ClickAdd(object sender, RoutedEventArgs e)
        {
            Discipline discipline = new Discipline()
            {
                IdStudent = Convert.ToInt32(StudentTb.Text),
                IdDisciplinesList = Convert.ToInt32(DisciplineListCB.SelectedValue),
                NumberOfHours = Convert.ToInt32(NumberOfHoursTb.Text),
                Rating = Convert.ToInt32(RatingTb.Text)
            };

            db.Discipline.Add(discipline);
            db.SaveChanges();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ClickRemove(object sender, RoutedEventArgs e)
        {

        }
    }
}
