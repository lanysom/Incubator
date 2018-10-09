using Incubator.UI.Repository;
using Incubator.UI.Repository.Interfaces;
using StructureMap;
using System.Windows;

namespace Incubator.UI.IoC
{
    public static class Bootstrapper
    {
        public static readonly IContainer Container = new Container();

        public static void Initialize()
        {
            Container.Configure(c =>
            {
                c.For<IBatchRepository>().Use<BatchRepository>();
            });
        }

        public static void Open<TWindow, TViewModel>() where TWindow : Window, new()
        {
            var window = new TWindow() { DataContext = Container.GetInstance<TViewModel>() };
            window.ShowDialog();
        }
    }
}
