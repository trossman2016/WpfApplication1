using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBProjectMain
{
    public class RegLineObjectsCollection : ObservableCollection<CBRegLineObject>
    {
        public RegLineObjectsCollection() : base()
        {
            Add(new CBRegLineObject());
        }
    }
}
