using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.DataService;
using WpfApp1.ViewModel;
using WpfApp1.Views;

namespace WpfApp1.StartUp
{
    public class Bootstrapper
    {
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<EmployeeView>().AsSelf();
            builder.RegisterType<EmployeeVM>().AsSelf();
            builder.RegisterType<EmpDS>().As<IEmpDS>();

            return builder.Build();
        }
    }
}
