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
            Employee Roth = new Employee()
            {
                Role = "Executive",
                Title = "Mr",
                FirstName = "Moshe",
                LastName = "Roth",
                Salary = 250000
            };
            Employee Stark = new Employee()
            {
                Role = "Supervisor",
                Title = "Mr",
                FirstName = "Chaim",
                LastName = "Stark",
                Salary = 150000
            };
            Employee Spira = new Employee()
            {
                Role = "Supervisor",
                Title = "Mr",
                FirstName = "Moshe",
                LastName = "Spira",
                Salary = 160000
            };
            Employee Gold = new Employee()
            {
                Role = "Manager",
                Title = "Mr",
                FirstName = "Yehuda",
                LastName = "Gold",
                Salary = 120000
            };
            Employee Weiss = new Employee()
            {
                Role = "Manager",
                Title = "Mrs",
                FirstName = "Miriam",
                LastName = "Weiss",
                Salary = 120000
            };
            Employee Green = new Employee()
            {
                Role = "Employee",
                Title = "Mr",
                FirstName = "Shlomo",
                LastName = "Green",
                Salary = 65000
            };
            Employee Silver = new Employee()
            {
                Role = "Employee",
                Title = "Mrs",
                FirstName = "Ester",
                LastName = "Silver",
                Salary = 75000
            };
            Employee Weiser = new Employee()
            {
                Role = "Employee",
                Title = "Mr",
                FirstName = "Yakov",
                LastName = "Weiser",
                Salary = 70000
            };
            List<Employee> Employees = new List<Employee>();
            Employees.Add(Roth);
            Employees.Add(Stark);
            Employees.Add(Spira);
            Employees.Add(Gold);
            Employees.Add(Weiss);
            Employees.Add(Green);
            Employees.Add(Silver);
            Employees.Add(Weiser);

            List<Employee> EmployeesSorted = Employees.OrderBy(e => e.Bonus).ToList();
            list.ItemsSource = EmployeesSorted;
        }

        
    }

}
