using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace EmployeeRedactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Employee> Employees { get; set; } = new ObservableCollection<Employee>();
        public Employee SelectedItem { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;
            Employees = new ObservableCollection<Employee>();
            tbPosition.Items.Add("Boss");
            tbPosition.Items.Add("Noob'ик");
            tbPosition.Items.Add("Manager");
            tbPosition.Items.Add("Not Selected");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tbName.Text.Length != 0)
            {
                if (tbSurname.Text.Length != 0)
                {
                    if (tbMiddleName.Text.Length != 0)
                    {
                        if (tbPosition.Text.Length != 0)
                        {
                            if(tbPosition.Text.Length !=0)
                            {
                                Employees.Add(new Employee(tbName.Text, tbSurname.Text, tbMiddleName.Text, tbPosition.Text));
                                empList.ItemsSource = Employees;
                            }
                            else
                            {
                                MessageBox.Show("Here some empty strings,check it!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Here some empty strings,check it!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Here some empty strings,check it!");
                    }
                }
                else
                {
                    MessageBox.Show("Here some empty strings,check it!");
                }
            }
            else
            {
                MessageBox.Show("Here some empty strings,check it!");
            }
            //Employees.Add(new Employee(tbName.Text, tbSurname.Text, tbMiddleName.Text, tbPosition.Text));
            //empList.ItemsSource = Employees;
        }

        private void empList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            editor.IsEnabled = true;
        }
    }
}
