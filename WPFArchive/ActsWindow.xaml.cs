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
using Word = Microsoft.Office.Interop.Word;

namespace WPFArchive
{
   
    public partial class ActsWindow : Window
    {
        DbArchiveEntities db = new DbArchiveEntities();

        private readonly string TemplateFileName = @"G:\repos\WPFArchive\WPFArchive\Resources\ШаблонАкт1.docx";
        //private readonly string TemplateFileName1 = @"G:\repos\WPFArchive\WPFArchive\Resources\ШаблонАкт2.docx";

        public ActsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //GridStudents.ItemsSource = db.Student.ToList();
        }

        private void ReplaceWordStub(string stubToReplace, string text, Microsoft.Office.Interop.Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void ToFormActs1(object sender, RoutedEventArgs e)
        {
            //var datehelp = Convert.ToDateTime(DateHelpDP1.SelectedDate.Value.ToShortDateString());
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = false;
            var wordDoucument = wordApp.Documents.Open(TemplateFileName);
            //ReplaceWordStub("{datehelp}", Convert.ToString(datehelp.ToString("dd.MM.yy")), wordDoucument);
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".docx"; // Default file extension           
            Nullable<bool> result = dlg.ShowDialog();
            string filename = "";
            if (result == true)
            {
                filename = dlg.FileName;
            }
            wordDoucument.SaveAs(filename);
            wordApp.Visible = true;
            wordDoucument = null;
        }

        
    }
}
