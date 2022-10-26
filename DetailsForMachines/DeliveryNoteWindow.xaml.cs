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

namespace DetailsForMachines
{
    /// <summary>
    /// Логика взаимодействия для DeliveryNoteWindow.xaml
    /// </summary>
    public partial class DeliveryNoteWindow : Window
    {

        public static DeliveryNote NoteToChange;

     
        public DeliveryNoteWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод возврата на главное окно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackToMainWindow(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            MainWindow.WindowMain.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Метод удаления накладной
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveDeliveryNote(object sender, RoutedEventArgs e)
        {
            MainWindow.ToDelete = (sender as Button).DataContext as DeliveryNote;
            MainWindow.AcceptWindow.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Метод открытия окна для изменения накладной
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDeliveryNote(object sender, RoutedEventArgs e)
        {
            NoteToChange = (sender as Button).DataContext as DeliveryNote;
            MainWindow.DevChangeWindow.ReceiveDate.Text = NoteToChange.ReceiveDate.ToString();
            MainWindow.DevChangeWindow.DetailPrice.Text = NoteToChange.DetailPrice.ToString();
            MainWindow.DevChangeWindow.DetailsBox.ItemsSource = MainWindow.db.Detail.ToList();
            MainWindow.DevChangeWindow.DetailsBox.SelectedItem = NoteToChange.Detail;
            MainWindow.DevChangeWindow.StoragesBox.ItemsSource = MainWindow.db.Storage.ToList();
            MainWindow.DevChangeWindow.StoragesBox.SelectedItem = NoteToChange.Storage;
            MainWindow.DevChangeWindow.WorkersBox.ItemsSource = MainWindow.db.Worker.ToList();
            MainWindow.DevChangeWindow.WorkersBox.SelectedItem = NoteToChange.Worker;
            MainWindow.DevChangeWindow.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Метод закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            e.Cancel = true;
            MainWindow.WindowMain.Visibility = Visibility.Visible;
        }
    }
}
