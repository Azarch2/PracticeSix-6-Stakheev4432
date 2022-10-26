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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Word = Microsoft.Office.Interop.Word; 

namespace DetailsForMachines
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static DeliveryNote ToDelete;
        public static MainWindow WindowMain;
        public static DeliveryNoteWindow DevNoteWindow = new DeliveryNoteWindow();
        public static StorageAddWindow StorageAddWindow = new StorageAddWindow();
        public static StorageWindow WindowStorage = new StorageWindow();
        public static AcceptWindow AcceptWindow = new AcceptWindow();
        public static DeliveryNoteChangeWindow DevChangeWindow = new DeliveryNoteChangeWindow();
        public static MachinesAndDetailsEntities db = new MachinesAndDetailsEntities();
        public MainWindow()
        {
            InitializeComponent();
            WindowMain = this;
        }
        /// <summary>
        /// Метод выхода из приложения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeaveFromApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Метод перехода на окно работы с накладными
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoToDeliveryNoteWindow(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            DevNoteWindow.DeliveryNoteList.ItemsSource = db.DeliveryNote.ToList();
            DevNoteWindow.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Метод перехода на окно работы со складами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoStorageWindow(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            WindowStorage.StorageList.ItemsSource = db.Storage.ToList();
            WindowStorage.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Метод генерации отчёта о складах
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateDocClick(object sender, RoutedEventArgs e)
        {
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Add();
            Word.Paragraph pardo = doc.Paragraphs.Add();
            Word.Range pardorange = pardo.Range;
            pardorange.Text = "Отчёт о складах, используемых компанией";
            pardorange.Font.Size = 22;
            pardo.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            pardorange.InsertParagraphAfter();
            Word.Paragraph par = doc.Paragraphs.Add();
            Word.Range range = par.Range;
            Word.Table table = doc.Tables.Add(range, db.Storage.ToList().Count + 1, 4);
            table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            int rowcount = 1;
            table.Cell(rowcount, 1).Range.Text = "Код";
            table.Cell(rowcount, 2).Range.Text = "Номер";
            table.Cell(rowcount, 3).Range.Text = "Адрес";
            table.Cell(rowcount, 4).Range.Text = "Площадь";
            table.Rows[1].Range.Font.Size = 14;
            table.Rows[1].Range.Bold = 1;
            rowcount++;
            foreach (Storage item in db.Storage)
            {
                table.Cell(rowcount, 1).Range.Text = item.Id.ToString();
                table.Cell(rowcount, 2).Range.Text = item.Number;
                table.Cell(rowcount, 3).Range.Text = item.Address;
                table.Cell(rowcount, 4).Range.Text = item.Area.ToString();
                rowcount++;
            }
            table.Range.Cells.VerticalAlignment = Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
            table.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            table.Range.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
            table.Range.ParagraphFormat.SpaceAfter = 0.0f;
            table.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow);
            table.Range.Font.Name = "Comic Sans MS";
            app.Visible = true;
        }
        /// <summary>
        /// Метод обработк закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
