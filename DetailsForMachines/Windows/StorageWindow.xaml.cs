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
    /// Логика взаимодействия для MachineWindow.xaml
    /// </summary>
    public partial class StorageWindow : Window
    {
        public StorageWindow()
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
        /// Метод обработки события нажатия на кнопку "Добавить" с окна StorageWindow
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDeliveryNote(object sender, RoutedEventArgs e)
        {
            MainWindow.StorageAddWindow.Visibility = Visibility.Visible;
            MainWindow.StorageAddWindow.Address.Text = "";
            MainWindow.StorageAddWindow.Area.Text = "";
            MainWindow.StorageAddWindow.Number.Text = "";
        }
        /// <summary>
        /// Метод обработки закрытия окна
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
