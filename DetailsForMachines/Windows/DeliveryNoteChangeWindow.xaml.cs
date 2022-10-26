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
    /// Логика взаимодействия для DeliveryNoteChangeWindow.xaml
    /// </summary>
    public partial class DeliveryNoteChangeWindow : Window
    {
        public DeliveryNoteChangeWindow()
        {
            InitializeComponent();
        }
        public static bool CheckSuccess = false;
        /// <summary>
        /// Метод изменения Накладной
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeDeliveryNote(object sender, RoutedEventArgs e)
        {
            foreach(DeliveryNote item in MainWindow.db.DeliveryNote)
            {
             
                if(item.Id == DeliveryNoteWindow.NoteToChange.Id)
                {
                 
                    DeliveryNote note = new DeliveryNote();
                    try
                    {
                        note.Worker = (WorkersBox.SelectedItem as Worker);
                    }
                    catch
                    {
                        MessageBox.Show("Возникла непредвиденная ошибка");
                        break;
                    }

                    try
                    {
                        note.Storage = (StoragesBox.SelectedItem as Storage);
                    }
                    catch
                    {
                        MessageBox.Show("Возникла непредвиденная ошибка");
                        break;
                    }
                    try
                    {
                        note.ReceiveDate = DateTime.Parse(ReceiveDate.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Вы неверно ввели Дату \nВерный формат даты ДД:ММ:ГГ 00:00:00");
                        break;
                    }

                    try
                    {
                        note.DetailPrice = decimal.Parse(DetailPrice.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Вы неверно ввели Цену \nНеобходимо использовать тип Decimal(денежный)");
                        break;
                    }
                    try
                    {
                        note.Detail = (DetailsBox.SelectedItem as Detail);
                    }
                    catch
                    {
                        MessageBox.Show("Возникла непредвиденная ошибка");
                        break;
                    }
                    MainWindow.db.DeliveryNote.Remove(item);
                    MainWindow.db.DeliveryNote.Add(note);
                    CheckSuccess = true;
                }
            }
            if (CheckSuccess)
            {
                MessageBox.Show("Вы успешно изменили накладную");
                this.Visibility = Visibility.Hidden;
                MainWindow.db.SaveChanges();
                MainWindow.DevNoteWindow.DeliveryNoteList.ItemsSource = MainWindow.db.DeliveryNote.ToList();
            }
            CheckSuccess = false;
        }
        /// <summary>
        /// Метод закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Visibility = Visibility.Hidden;
        }
    }
}
