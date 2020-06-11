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
   
    public partial class ReportsWindow : Window
    {
        DbArchiveEntities db = new DbArchiveEntities();

        private readonly string TemplateFileName = @"G:\repos\WPFArchive\WPFArchive\Resources\ШаблонВыпускник.docx";
        private readonly string TemplateFileName1 = @"G:\repos\WPFArchive\WPFArchive\Resources\ШаблонОценки.docx";

        public ReportsWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            GridStudents.ItemsSource = db.Student.ToList();         
            var groupStudent = db.GroupStudentNumber.ToList();        
            GridDiscipline.ItemsSource = db.Discipline.ToList();
            GridStudent.ItemsSource = db.Student.ToList();
            
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }


        private void ToForm_Click(object sender, RoutedEventArgs e)
        {
            

            //var datehelp = Convert.ToDateTime(DateHelpDP.SelectedDate.Value.ToShortDateString());
            //var Lastname = LastNameTB.Text; 
            //var Firstname = FirstTB.Text;  
            //var Middlename = MiddleNameTB.Text; 
            //var Dateofbirtth = Convert.ToDateTime(DateofBirthDP.SelectedDate.Value.ToShortDateString()); 
            //var Enroll = Convert.ToDateTime(EnrollDP.SelectedDate.Value.ToShortDateString()); 
            //var Group = GroupTB.Text; 
            //var Speciality = SpecialtyTB.Text; 
            //var DatePeriod = DatePeriodTB.Text;           
            //var EnrollmentDate = Convert.ToDateTime(EnrollmentDateDP.SelectedDate.Value.ToShortDateString()); 
            //var EnrollmentNumber = EnrollmentNumberTB.Text;
            //var EnrollStudent = Convert.ToDateTime(EnrollStudentDP.SelectedDate.Value.ToShortDateString());
            //var orderReleasedDate = Convert.ToDateTime(ReleaseDate.SelectedDate.Value.ToShortDateString());
            //var NumberReleased = ReleaseNumberTB.Text;
            //var Series = SeriesTB.Text;
            //var Number = NumberTB.Text;
            //var ApplicationDate = Convert.ToDateTime(ApplicationDateDP.SelectedDate.Value.ToShortDateString());
            //var RegistrationNumber = RegistrationNumberTB.Text;


            var wordApp = new Word.Application();
            wordApp.Visible = false;
            try
            {
                var Lastname = LastNameTB.Text;
                var Firstname = FirstTB.Text;
                var Middlename = MiddleNameTB.Text;
                var Dateofbirtth = Convert.ToDateTime(DateofBirthDP.SelectedDate.Value.ToShortDateString());
                var Enroll = Convert.ToDateTime(EnrollDP.SelectedDate.Value.ToShortDateString());
                var Group = GroupTB.Text;
                var Speciality = SpecialtyTB.Text;
                var DatePeriod = DatePeriodTB.Text;
                var EnrollmentDate = Convert.ToDateTime(EnrollmentDateDP.SelectedDate.Value.ToShortDateString());
                var EnrollmentNumber = EnrollmentNumberTB.Text;
                var EnrollStudent = Convert.ToDateTime(EnrollStudentDP.SelectedDate.Value.ToShortDateString());
                //var orderReleasedDate = Convert.ToDateTime(ReleaseDate.SelectedDate.Value.ToShortDateString());
                var NumberReleased = ReleaseNumberTB.Text;
                var Series = SeriesTB.Text;
                var Number = NumberTB.Text;
                var ApplicationDate = Convert.ToDateTime(ApplicationDateDP.SelectedDate.Value.ToShortDateString());
                var RegistrationNumber = RegistrationNumberTB.Text;

                var wordDoucument = wordApp.Documents.Open(TemplateFileName);
                //ReplaceWordStub("{datehelp}", Convert.ToString(datehelp.ToString("dd.MM.yy")), wordDoucument);
                ReplaceWordStub("{lastname}", Lastname, wordDoucument);
                ReplaceWordStub("{firstname}", Firstname, wordDoucument);
                ReplaceWordStub("{middlename}", Middlename, wordDoucument);
                ReplaceWordStub("{dateofbirtth}", Convert.ToString(Dateofbirtth.ToString("dd.MM.yy")), wordDoucument);
                ReplaceWordStub("{enrolldate}", Convert.ToString(Enroll.ToString("dd.MM.yy")), wordDoucument);
                ReplaceWordStub("{group}", Group, wordDoucument);
                ReplaceWordStub("{speciality}", Speciality, wordDoucument);
                ReplaceWordStub("{dateperiod}", DatePeriod, wordDoucument);
                ReplaceWordStub("{EnrollmentrDate}", Convert.ToString(EnrollmentDate.ToString("dd.MM.yy")), wordDoucument);
                ReplaceWordStub("{EnrollmentNumber}", EnrollmentNumber, wordDoucument);
                ReplaceWordStub("{enrollstudent}", Convert.ToString(EnrollStudent.ToString("dd.MM.yy")), wordDoucument);
                ReplaceWordStub("{lastname}", Lastname, wordDoucument);
                ReplaceWordStub("{firstname}", Firstname, wordDoucument);
                ReplaceWordStub("{middlename}", Middlename, wordDoucument);
                ReplaceWordStub("{speciality}", Speciality, wordDoucument);
                //ReplaceWordStub("{orderReleasedDate}", Convert.ToString(orderReleasedDate.ToString("dd.MM.yy")), wordDoucument);
                ReplaceWordStub("{NumberReleased}", NumberReleased, wordDoucument);
                ReplaceWordStub("{seria}", Series, wordDoucument);
                ReplaceWordStub("{number}", Number, wordDoucument);
                ReplaceWordStub("{DiplomaDate}", Convert.ToString(ApplicationDate.ToShortDateString()), wordDoucument);
                ReplaceWordStub("{RegistrationNumber}", RegistrationNumber, wordDoucument);

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
            catch
            {
                MessageBox.Show("Ошибка заполнения ");
            }
        }

        private void ToForm1_Click(object sender, RoutedEventArgs e)
        {
            

            var datehelp = Convert.ToDateTime(DateHelpDP1.SelectedDate.Value.ToShortDateString());
            var Lastname = LastNameTB1.Text;
            var Firstname = FirstTB1.Text;
            var Middlename = MiddleNameTB1.Text;
            var Dateofbirtth = Convert.ToDateTime(DateofBirthDP1.SelectedDate.Value.ToShortDateString());
            var Speciality = SpecialtyTB1.Text;
            

            var wordApp = new Word.Application();
            wordApp.Visible = false;
            try
            {
                var wordDoucument = wordApp.Documents.Open(TemplateFileName1);
                ReplaceWordStub("{datehelp}", Convert.ToString(datehelp.ToString("dd.MM.yy")), wordDoucument);
                ReplaceWordStub("{lastname}", Lastname, wordDoucument);
                ReplaceWordStub("{firstname}", Firstname, wordDoucument);
                ReplaceWordStub("{middlename}", Middlename, wordDoucument);
                ReplaceWordStub("{dateofbirtth}", Convert.ToString(Dateofbirtth.ToString("dd.MM.yy")), wordDoucument);               
                ReplaceWordStub("{speciality}", Speciality, wordDoucument);
                
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
            catch
            {
                MessageBox.Show("Ошибка заполнения ");
            }
        }
    }
}
