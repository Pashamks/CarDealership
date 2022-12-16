using Front.ViewModels;
using System.Windows;

namespace Front
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private CarsViewModel _viewModel;
        public App()
        {
            _viewModel = new CarsViewModel();
            var window = new MainWindow() { DataContext = _viewModel };
            window.Show();
        }
    }
}
