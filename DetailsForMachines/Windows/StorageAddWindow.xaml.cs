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
    /// Логика взаимодействия для DeliveryNoteAddWindow.xaml
    /// </summary>
    public partial class StorageAddWindow : Window
    {
        public StorageAddWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод обработки закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
        /// <summary>
        /// Метод добавления склада
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStorage(object sender, RoutedEventArgs e)
        {
            Storage storage = new Storage();
            bool CheckSuccess = true;
            int count = MainWindow.db.Storage.Where(c=> c.Number == Number.Text).Count();
            if (count >= 1)
            {
                MessageBox.Show("Такой номер хранилища уже занят");
            }
            else
            {
                try
                {
                    storage.Number = Number.Text;
                }
                catch
                {
                    MessageBox.Show("Вы ввели неверный номер хранилища \nОн должен находиться в текстовом формате");
                    CheckSuccess = false;
                }
                try
                {
                    storage.Address = Address.Text;
                }
                catch
                {
                    MessageBox.Show("Вы ввели неверный адрес хранилища \nОн должен находиться в текстовом формате");
                    CheckSuccess = false;
                }
                try
                {
                    storage.Area = int.Parse(Area.Text);
                }
                catch
                {
                    MessageBox.Show("Вы ввели неверную площадь хранилища \nОна должна находиться в целочисленном формате");
                    CheckSuccess = false;
                }
                if (CheckSuccess)
                {
                    MainWindow.db.Storage.Add(storage);
                    MainWindow.db.SaveChanges();
                    MainWindow.WindowStorage.StorageList.ItemsSource = MainWindow.db.Storage.ToList();
                    this.Visibility = Visibility.Hidden;
                    MessageBox.Show("Вы успешно добавили склад с номером: " + storage.Number);
                }
            }
        }
    }
}
