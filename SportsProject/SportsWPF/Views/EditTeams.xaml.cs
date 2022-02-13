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
    /// Interaction logic for EditTeams.xaml
    /// </summary>
    public partial class EditTeams : Window
    {
        AdminViewModel avm;

        public EditTeams()
        {
            this.avm = ((MainWindow)Application.Current.MainWindow).avm;
            InitializeComponent();
            DataContext = avm;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EditPlayer edit = new EditPlayer();
            edit.Show();
        }
    }
}
