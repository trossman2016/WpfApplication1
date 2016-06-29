using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBProjectMain
{
    public class CBRegLineObject : HelperItems
    {
        private DateTime _date;
        private bool _ischeck;
        private double _debitamount;
        private double _creditamount;
        private int _checknumber;
        private double _balance;
        private string _transdescription;
        private int _linenumber;

        public DateTime Date
        {
            get { return this._date; }
            set
            {
                this._date = value;
                NotifyPropertyChanged("Date");
            }
        }

        public bool IsCheck
        {
            get { return this._ischeck; }
            set
            {
                this._ischeck = value;
                NotifyPropertyChanged("IsCheck");
            }
        }

        public double DebitAmount
        {
            get { return this._debitamount; }
            set
            {
                this._debitamount = value;
                NotifyPropertyChanged("DebitAmount");
            }
        }

        public double CreditAmount
        {
            get { return this._creditamount; }
            set
            {
                this._creditamount = value;
                NotifyPropertyChanged("CreditAmount");
            }
        }

        public int CheckNumber
        {
            get { return this._checknumber; }
            set
            {
                this._checknumber = value;
                NotifyPropertyChanged("CheckNumber");
            }
        }

        public double Balance
        {
            get { return this._balance; }
            set
            {
                this._balance = value;
                NotifyPropertyChanged("Balance");
            }
        }

        public string TransDescription
        {
            get { return this._transdescription; }
            set
            {
                this._transdescription = value;
                NotifyPropertyChanged("TransDescription");
            }
        }
        
        public int LineNumber
        {
            get { return this._linenumber; }
            set
            {
                this._linenumber = value;
                NotifyPropertyChanged("LineNumber");
            }
        }
    }
}
