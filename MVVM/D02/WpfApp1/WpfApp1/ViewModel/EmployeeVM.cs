using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Command;
using WpfApp1.DataService;
using WpfApp1.Models;

namespace WpfApp1.ViewModel
{
    public class EmployeeVM :VMBase
    {

        public ObservableCollection<Employee> employees { get; set; }
        public ICommand DeleteCommand { get; set; } 
        public ICommand SelectCommand { get; set; }

        public Employee SelectEmp { get; set; }

        public ICommand SaveCommand { get; set; }
        public Employee EmployeeData { get; set; }

        IEmpDS _service;
        public EmployeeVM(IEmpDS empDS)
        {
            this._service = empDS;
            employees= new ObservableCollection<Employee>();
            DeleteCommand = new RelayCommand(DeleteStudent,null);
            SelectCommand= new RelayCommand(EditEmployee,null);
            SaveCommand = new RelayCommand(SaveEmp, null);
            EmployeeData = new Employee();
            SelectEmp = new();

        }

        private void SaveEmp(object obj)
        {

            if (EmployeeData != null)
            {
                SelectEmp.FirstName = EmployeeData.FirstName;
                SelectEmp.LastName = EmployeeData.LastName;
                SelectEmp.Grade = EmployeeData.Grade;

                try
                {

                    if (EmployeeData.Id <= 0)
                    {
                        _service.Add(EmployeeData);
                        MessageBox.Show("Record Added");

                    }
                    else
                    {

                        SelectEmp.Id = EmployeeData.Id;

                        _service.Update(SelectEmp);
                        MessageBox.Show("Record Is Updated");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    Load();
                }




            }
        }

        private void EditEmployee(object obj)
        {
            var Emp = (Employee)obj;
            EmployeeData.Id = Emp.Id;
            EmployeeData.FirstName = Emp.FirstName;
            EmployeeData.LastName = Emp.LastName;
            EmployeeData.Grade = Emp.Grade;
            Load();
        }

        private void DeleteStudent(object obj)
        {
            if (MessageBox.Show("Delete Record", "Are You Sure", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {

                    _service.Delete((int)obj);
                    MessageBox.Show("Record Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Load();
                }

            }
        }

        public void Load()
        {
           var Emps= _service.GetAll();
            employees.Clear();
            foreach (var item in Emps)
            {
                employees.Add(item);
            }
        }
        
    }
}
