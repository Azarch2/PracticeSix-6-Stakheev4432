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
    /// Логика взаимодействия для AcceptWindow.xaml
    /// </summary>
    public partial class AcceptWindow : Window
    {
        public AcceptWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод обработки события нажатия на кнопку "Да"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YesClick(object sender, RoutedEventArgs e)
        {
            MainWindow.db.DeliveryNote.Remove(MainWindow.ToDelete);
            MainWindow.db.SaveChanges();
            MainWindow.DevNoteWindow.DeliveryNoteList.ItemsSource = MainWindow.db.DeliveryNote.ToList();
            this.Visibility = Visibility.Hidden;
            MessageBox.Show("Объект был удалён");
        }
        /// <summary>
        /// Метод обработки события нажатия на кнопку "Нет"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoClick(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Метод обработки закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
