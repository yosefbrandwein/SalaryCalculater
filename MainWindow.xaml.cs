using System;
using System.Collections.Generic;
using System.IO;
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

namespace SalaryCalculater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            
            List<Employee> Employees = new List<Employee>();
            using (var reader = new StreamReader(@"C:\Users\User\source\repos\Salary.csv"))
            {

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var employee = new Employee()
                    {
                        Role = values[0],
                        Title = values[1],
                        FirstName = values[2],
                        LastName = values[3],
                        Salary = Convert.ToInt32(values[4])
                    };
                    Employees.Add(employee);
                }
            }

            List<Employee> EmployeesSorted = Employees.OrderBy(e => e.Bonus).ToList();
            list.ItemsSource = EmployeesSorted;
        }

        
    }

}
