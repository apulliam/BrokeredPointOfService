// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ModernPosExplorer.Common;
using ModernPosExplorer.Views;
using BrokeredPointOfService;

namespace ModernPosExplorer.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private PosExplorer PosExplorer { get; set; }
        public Helpers.RelayCommand<DeviceInfo> ClickDevice { get; private set; }

        private ObservableCollection<DeviceInfo> devices;
        public ObservableCollection<DeviceInfo> Devices
        {
            get
            {
                return devices;
            }

            set
            {
                devices = value;
                RaisePropertyChanged("Devices");
            }
        }
        public MainViewModel()
        {
            devices = new ObservableCollection<DeviceInfo>();
            ClickDevice = new Helpers.RelayCommand<DeviceInfo>(Click);
        }

        public void LoadData()
        {
            PosExplorer = new PosExplorer();
            var deviceArray =  PosExplorer.GetDevicesByCompatibilities(DeviceCompatibilities.CompatibilityLevel1);
            foreach (var device in deviceArray)
            {
                devices.Add(device);
            }
        }

        private void Click(DeviceInfo device)
        {
            App.AppFrame.Navigate(typeof(DevicePage), device);
        }

        public override void Dispose()
        {
            if (PosExplorer != null)
                PosExplorer.Dispose();
        }
    }
}
