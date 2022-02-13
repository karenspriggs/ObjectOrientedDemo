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
using Currency.US;
using Currency;
using CurrencyWPF.Serializing;

namespace CurrencyWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel repoModel = new ViewModel();
        WPFRepoSaver repoSaver = new WPFRepoSaver();

        public MainWindow()
        {
            InitializeComponent(); 
            DataContext = repoModel;
            MakeChange1.DataContext = repoModel;
            CurrencyRepo1.Visibility = Visibility.Collapsed;
            CurrencyRepo1.DataContext = repoModel;
        }

        private void ChangeLabel_Loaded(object sender, RoutedEventArgs e)
        {
            //MakeChange1.DataContext = repoModel;
        }

        private void MakeChangeButton_Click(object sender, RoutedEventArgs e)
        {
            BackButton.Visibility = Visibility.Visible;
            MakeChangeButton.Visibility = Visibility.Collapsed;
            CurrencyRepo1.Visibility = Visibility.Visible;
            MakeChange1.Visibility = Visibility.Collapsed;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            BackButton.Visibility = Visibility.Collapsed;
            MakeChangeButton.Visibility = Visibility.Visible;
            CurrencyRepo1.Visibility = Visibility.Collapsed;
            MakeChange1.Visibility = Visibility.Visible;
        }
    }
}
