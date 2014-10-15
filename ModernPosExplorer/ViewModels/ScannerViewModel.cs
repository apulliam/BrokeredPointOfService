using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using ModernPosExplorer.Common;
using ModernPosExplorer.Views;
using BrokeredPointOfService;

namespace ModernPosExplorer.ViewModels
{
    public class ScannerViewModel : ViewModelBase
    {
        private DeviceViewModel DeviceViewModel { get; set; }

        private Scanner Scanner 
        {
            get
            {
                return DeviceViewModel.PosCommon as Scanner;
            }
        }

        public bool AutoDisable 
        { 
            get
            {
                return Scanner.AutoDisable;
            }
            set
            {
                try
                {
                    Scanner.AutoDisable = value;
                    RaisePropertyChanged("AutoDisable");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Scanner.LastException.ToString();
                }
            }
        }

        public bool DataEnabled
        {
            get
            {
                return Scanner.DataEventEnabled;
            }
            set
            {
                try
                {
                    Scanner.DataEventEnabled = value;
                    RaisePropertyChanged("DataEnabled");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Scanner.LastException.ToString();
                }
            }
        }

        public bool DecodeData
        {
            get
            {
                return Scanner.DecodeData;
            }
            set
            {
                try
                {
                    Scanner.DecodeData = value;
                    RaisePropertyChanged("DecodeData");
                }
                catch (Exception ex)
                {
                    DeviceViewModel.ErrorOutput = Scanner.LastException.ToString();
                }

            }
        }

        public string ScanData
        {
            get
            {
                byte[] b = Scanner.ScanData;
                string str = string.Empty;
                for (int i = 0; i < b.Length; i++)
                    str += (b[i].ToString(System.Globalization.CultureInfo.CurrentCulture) + " ");
                str += "\r\n";
                return str;
            }
        }
        
        public string ScanDataLabel
        {
            get
            {
                byte[] b = Scanner.ScanData;
                string str = string.Empty;
                b = Scanner.ScanDataLabel;
                for (int i = 0; i < b.Length; i++)
                    str += (char)b[i];
                str += "\r\n";
                return str;
            }
        }

        public string ScanDataType
        {
            get
            {
                return Scanner.ScanDataType.ToString();
            }
        }
     
        public void LoadData(DeviceViewModel deviceViewModel)
        {
            this.DeviceViewModel = deviceViewModel;
            Scanner.DataEvent += Scanner_DataEvent;
            Scanner.ErrorEvent += Scanner_ErrorEvent;
        }

        async void Scanner_ErrorEvent(object sender, DeviceErrorEventArgs e)
        {
            var coreWindowDispatcher = CoreApplication.MainView.CoreWindow.Dispatcher;
            await coreWindowDispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                DeviceViewModel.ErrorOutput = e.ToString();
            }).AsTask();
        }

        async void Scanner_DataEvent(object sender, DataEventArgs e)
        {
            var coreWindowDispatcher = CoreApplication.MainView.CoreWindow.Dispatcher;
            await coreWindowDispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                UpdateSettings();
                DeviceViewModel.UpdateSettings();
            }).AsTask();
        }

        public void UpdateSettings()
        {
            // fire property changed event(s) to requery state from PosCommon
            RaisePropertyChanged("DataEnabled");
            RaisePropertyChanged("ScanData");
            RaisePropertyChanged("ScanDataLabel");
            RaisePropertyChanged("ScanDataType");

        }

        public override void Dispose()
        {
            if (Scanner != null)
            {
                Scanner.ErrorEvent -= Scanner_ErrorEvent;
                Scanner.DataEvent -= Scanner_DataEvent;
            }
        }
    }
}
