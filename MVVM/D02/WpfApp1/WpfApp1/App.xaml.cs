using Autofac;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.DataService;
using WpfApp1.StartUp;
using WpfApp1.ViewModel;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //var Window = new  EmployeeView(new EmployeeVM(new EmpDS()));
            //Window.Show();

            var bootstarpper = new Bootstrapper();
            var Container = bootstarpper.Bootstrap();
            var Window = Container.Resolve<EmployeeView>();
            Window.Show();
        }
    }
}
