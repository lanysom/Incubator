using StructureMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Core.Interfaces;
using IContainer = StructureMap.IContainer;

namespace UI.Core
{
    public class WindowViewModelBase : IWindowViewModel, INotifyPropertyChanged
    {
        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Properties

        public IView View { get; set; }

        public IWindow Window { get; set; }

        public IContainer Container { get; set; }

        #endregion
        
        public WindowViewModelBase(IWindow window, IContainer container)
        {
            Window = window;
            Window.DataContext = this;

            Container = container;
        }

        protected void ShowView<TViewModel>() where TViewModel : IViewModel
        {
            View = Container.GetInstance<TViewModel>().View;
        } 
    }
}
