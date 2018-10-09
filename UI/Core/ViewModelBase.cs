using StructureMap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Core.Interfaces;
using IContainer = StructureMap.IContainer;

namespace UI.Core
{
    public abstract class ViewModelBase : IViewModel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public IView View { get; set; }

        public IContainer Container { get; set; }

        public ViewModelBase(IView view, IContainer container)
        {
            View = view;
            View.DataContext = this;

            Container = container;
        }
    }
}
