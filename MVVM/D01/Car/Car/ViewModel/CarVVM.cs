using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using Car.Command;
using Car.Model;

namespace Car.ViewModel
{
    public class CarVVM
    {

        public ObservableCollection<carModel> cars { get; set; }
        public ICommand AddCommand { get; set; }

        public carModel car { get; set; }
        public  CarVVM() 
        {
            AddCommand = new FirstCommnad(Add,CanADD);
            car = new carModel();
            cars = new ObservableCollection<carModel>()
            {
                new carModel() {ID=1,Name="KIA",Model=123,Color="Red" },
                new carModel() {ID=2,Name="Jeep",Model=456,Color="Black" },
                new carModel() {ID=3,Name="Nissan",Model=789,Color="Blue" },
                new carModel() {ID=4,Name="Toyota",Model=000,Color="White" },
            };
        }

        private void Add(object obj)
        {

            carModel? car = obj as carModel;
            var o = new carModel();
            o.ID = car.ID;
            o.Name = car.Name;
            o.Model = car.Model;
            o.Color = car.Color;
            cars.Add(o);
            MessageBox.Show("Added");
        }

        private bool CanADD(object obj)
        {
            return true;
        }
    }
}
