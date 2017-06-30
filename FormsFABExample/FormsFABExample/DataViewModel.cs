using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FormsFABExample
{
    public class DataViewModel : INotifyPropertyChanged
    {
        private bool _toggleOnOff = true;
        public bool OnAndOff
        {
            get
            {
                return _toggleOnOff;
            }
            set
            {
                _toggleOnOff = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            var handle = PropertyChanged;
            handle?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
