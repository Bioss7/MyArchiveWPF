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
    
    public partial class DisciplineWindow : Window
    {
        DbArchiveEntities db = new DbArchiveEntities();

        public DisciplineWindow()
        {
            InitializeComponent();
            
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
            GridStudent.ItemsSource = db.Student.ToList();
            GridDiscipline.ItemsSource = db.Discipline.ToList();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            Discipline discipline = new Discipline();
            int num = (GridDiscipline.SelectedItem as Discipline).DisciplineId;
            var query = db.Discipline.Where(u => u.DisciplineId == num).FirstOrDefault();

            query.IdStudent = Convert.ToInt32(StudentTb.Text);
            query.IdDisciplinesList = Convert.ToInt32(DisciplineListCB.SelectedValue);
            query.NumberOfHours = Convert.ToInt32(NumberOfHoursTb.Text);
            query.Rating = Convert.ToInt32(RatingTb.Text);

            db.SaveChanges();
            GridStudent.ItemsSource = db.Student.ToList();
          
        }

        private void Button_ClickRemove(object sender, RoutedEventArgs e)
        {
            Discipline discipline = new Discipline();
            int num = (GridDiscipline.SelectedItem as Discipline).DisciplineId;
            var queryDel = db.Discipline.Where(d => d.DisciplineId == num).FirstOrDefault();
            db.Discipline.Remove(queryDel);
            db.SaveChanges();
            GridStudent.ItemsSource = db.Student.ToList();

        }

        private void TbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
           
                var q = db.Student.ToList().Where(x => (x.Person.Lastname + " " + x.Person.Firstname + " " + x.Person.Middlename)
               .ToLower()
               .Contains(TbSearch.Text.ToLower())).ToList();
                GridStudent.ItemsSource = q;
          
        }

        private void StudentTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            var q = db.Discipline.ToList().Where(x => (x.Student.StudentId + " ")
            .ToLower()
            .Contains(StudentTb.Text.ToLower()));
            GridDiscipline.ItemsSource = q;
        }
    }
}
