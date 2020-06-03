using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;
using Word = Microsoft.Office.Interop.Word;
using System.Printing;


namespace WPFArchive
{

    public partial class MainWindow : Window
    {
        //private readonly string TemplateFileName = @"G:\repos\WPFArchive\WPFArchive\Resources\Шаблон.docx";

        public MainWindow()
        {
            InitializeComponent();


        }
     
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
       
        private void printBtn_Click(object sender, RoutedEventArgs e)
        {
            
            //var dialog = new System.Windows.Controls.PrintDialog();
            //if (dialog.ShowDialog() == true)
            //{
            //    dialog.PrintVisual(this.card, "Визитная карточка");
            //}
        }


    }
}
