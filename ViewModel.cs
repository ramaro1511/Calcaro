using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcaro
{
    public class ViewModel : INotifyPropertyChanged
    {
        public Model Model { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        ViewModel(Model _model)
        {
            Model = _model;
        }
    }
}
