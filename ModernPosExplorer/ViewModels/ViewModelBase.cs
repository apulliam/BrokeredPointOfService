using System;
using System.ComponentModel;

namespace ModernPosExplorer.ViewModels
{
    public abstract class ViewModelBase: INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public abstract void Dispose();
    }
}
