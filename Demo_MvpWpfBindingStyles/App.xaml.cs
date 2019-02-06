using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Demo_MvpWpfBindingStyles.Presenters;
using Demo_MvpWpfBindingStyles.Views;

namespace Demo_MvpWpfBindingStyles
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            MainWindowPresenters mainWindowPresenters = new MainWindowPresenters();
            MainWindowView mainWindowView = new MainWindowView(mainWindowPresenters);

            mainWindowView.DataContext = mainWindowPresenters;

            mainWindowView.ShowDialog();
        }
    }
}
