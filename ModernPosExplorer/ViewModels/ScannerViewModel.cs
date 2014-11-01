// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
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
