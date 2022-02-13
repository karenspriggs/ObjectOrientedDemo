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
using System.Windows.Shapes;
using WPFSports.ViewModels;
using WPFSports.Views;
using WPFSports;
using SportsWPF.Views;

namespace SportsWPF.Views
{
    /// <summary>
    /// Interaction logic for EditSchedule.xaml
    /// </summary>
    public partial class EditSchedule : Window
    {
        AdminViewModel avm;

        public EditSchedule()
        {
            this.avm = ((MainWindow)Application.Current.MainWindow).avm;
            InitializeComponent();
            DataContext = avm;
        }
    }
}
