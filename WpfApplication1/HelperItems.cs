using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBProjectMain
{
    public class HelperItems
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal void NotifyPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler1 = this.PropertyChanged;
            if (PropertyChanged != null) handler1(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
