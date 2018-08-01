using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMsetup.ViewModel
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set
            {
                _employees = value;
                RaiseChange("Employees");
            }
        }

        public MainWindowViewModel()
        {
            Employees = GetEmployeeList();
        }

        ObservableCollection<Employee> GetEmployeeList()
        {
            ObservableCollection<Employee> employees = new ObservableCollection<Employee>();

            employees.Add(new Employee
            {
                MemberID = 1,
                Name = "Sheik",
                Department = "IT",
                Phone = "0123456789",
                Email = "sheik@mail.com",
                Salary = "∞"
            });

            return employees;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaiseChange(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
    }
}
