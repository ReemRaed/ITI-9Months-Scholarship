using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.ViewModel
{
    public class VMBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] String Prop = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Prop));
        }
    }
}
