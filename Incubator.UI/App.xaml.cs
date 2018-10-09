using Incubator.UI.IoC;
using Incubator.UI.View;
using Incubator.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Incubator.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Bootstrapper.Initialize();
            Bootstrapper.Open<MainWindow, MainViewModel>();
        }
    }
}
