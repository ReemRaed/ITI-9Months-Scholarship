using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp1.ViewModel;

namespace WpfApp1.Models
{
    public class Employee : VMBase
    {
        int id, grade;
        string fname, lname;

        public int Id
        {
            get { return id; }
            set { id = value; OnPropertyChanged(); }
        }
        public string FirstName
        {
            get { return fname; }
            set { fname = value; OnPropertyChanged(); }

        }
        public string LastName
        {
            get { return lname; }
            set { lname = value; OnPropertyChanged(); }

        }
        public int Grade
        {

            get { return grade; }
            set
            {
                grade = value; OnPropertyChanged();
            }

        }

    }
}
