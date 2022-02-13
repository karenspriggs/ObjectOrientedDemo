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
using WPFSports.ViewModels;
using WPFSports.Views;
using SportsWPF.Views;

namespace WPFSports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public AdminViewModel avm = new AdminViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = avm;
        }

        private void EditTeamsButton_Click(object sender, RoutedEventArgs e)
        {
            EditTeams edit = new EditTeams();
            edit.Show();
        }

        private void ScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            EditSchedule edit = new EditSchedule();
            edit.Show();
        }
    }
}
