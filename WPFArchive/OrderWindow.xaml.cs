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
    
    public partial class OrderWindow : Window
    {
        DbArchiveEntities db = new DbArchiveEntities();
        int GetP;
        public OrderWindow(int Pers)
        {
            InitializeComponent();

           
            GetP = Pers;
            if (GetP == 0)
            {
                DgOrderList.ItemsSource = db.OrderList.ToList();
            }
            ////DgOrderList.ItemsSource = db.OrderList.ToList();

            if (GetP != 0)
            DgOrderList.ItemsSource = db.OrderList.ToList().Where(u => u.IdPerson == GetP);
        }

        private void BtnAddOrder_Click(object sender, RoutedEventArgs e)
        {
            //int id = (DgOrderList.SelectedItem as Person).PersonId;
            try
            {
                OrderList orderList = new OrderList()
                {
                    IdPerson = int.Parse(TbPerson.Text),
                    DateOrder = DpDateOrder.SelectedDate,
                    NumberOrder = TbNumberOrder.Text,
                    TitleOrder = TbTitleOrder.Text
                };
                db.OrderList.Add(orderList);
                db.SaveChanges();

                //DgOrderList.ItemsSource = db.OrderList.ToList();
                DgOrderList.ItemsSource = db.OrderList.ToList().Where(u => u.IdPerson == GetP);
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка!");
            }   
           
        }

        private void BtnDelOrder_Click(object sender, RoutedEventArgs e)
        {
            int num = (DgOrderList.SelectedItem as OrderList).IdOrderList;
            var q = db.OrderList.Where(u => u.IdOrderList == num).FirstOrDefault();
            db.OrderList.Remove(q);
            db.SaveChanges();

            if (GetP == 0)          
                DgOrderList.ItemsSource = db.OrderList.ToList();

            if (GetP != 0)
                DgOrderList.ItemsSource = db.OrderList.ToList().Where(u => u.IdPerson == GetP);
        }

        private void TbSearch_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var q = db.OrderList.ToList().Where(x => (x.NumberOrder + " " + x.Person.Lastname + " " + x.Person.Firstname + " " + x.Person.Middlename)
            .ToLower()
            .Contains(TbSearch.Text.ToLower())).ToList();
            DgOrderList.ItemsSource = q;

        }
    }
}
