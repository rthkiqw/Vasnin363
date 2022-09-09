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

namespace class6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string mess;

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            mess = textBox.Text.Trim();
            if (cmbx.Items.Contains(mess))
            {
                MessageBox.Show("already exist");
                return;
            }

            if (mess.Length != 0)
                cmbx.Items.Add(mess);

            textBox.Text = "";

        }
        
        private void Button_Click_Remove(object sender, RoutedEventArgs e)
        {
            mess = textBox.Text.Trim();
            if (mess.Length != 0)
            {
                cmbx.Items.Remove(mess);
            }
            else
            {
                cmbx.Items.Remove(cmbx.SelectedItem);
                textBox.Text = "";
            }
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            cmbx.Items.Clear();
        }
    }
}
