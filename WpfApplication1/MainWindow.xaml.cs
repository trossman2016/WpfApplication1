using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CBProjectMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public RegLineObjectsCollection reglineCollection = new RegLineObjectsCollection();

        public MainWindow()
        {
            InitializeComponent();
            CBRegLineObject regLineObject = new CBRegLineObject()
            {
                Date = DateTime.Today,
                IsCheck = false,
                DebitAmount = 125.33,
                CreditAmount = 0.00,
                CheckNumber = 2244,
                Balance = 345.55,
                TransDescription = "New Transaction",
            };
        }
    }
}
