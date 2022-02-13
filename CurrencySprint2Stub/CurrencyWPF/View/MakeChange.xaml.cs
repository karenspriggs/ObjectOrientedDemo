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
using CurrencyWPF.ViewModels;
using CurrencyWPF.Serializing;

namespace CurrencyWPF.View
{
    /// <summary>
    /// Interaction logic for MakeChange.xaml
    /// </summary>
    public partial class MakeChange : UserControl
    {
        ViewModel repoModel = new ViewModel();
        
        public MakeChange()
        {
            InitializeComponent();
            DataContext = repoModel;
        }
    }
}
