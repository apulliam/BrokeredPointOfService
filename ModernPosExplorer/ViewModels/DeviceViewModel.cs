﻿// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using ModernPosExplorer.Common;
using ModernPosExplorer.Views;
using BrokeredPointOfService;
using System;

namespace ModernPosExplorer.ViewModels
{
    public class DeviceViewModel : ViewModelBase
    {

        public PosCommon PosCommon { get; private set; }

        private string errorOutput;
        public string ErrorOutput
        {
            get
            {
                return errorOutput;
            }
            set
            {
                errorOutput = value;
                RaisePropertyChanged("ErrorOutput");
            }
        }
       
        public string DeviceName
        {
            get
            {
                return PosCommon.DeviceName;
            }
        }

        public string DeviceDescription
        {
            get
            {
                return PosCommon.DeviceDescription;
            }
        }

        public string ServiceObjectDescription 
        { 
            get
            {
                return PosCommon.ServiceObjectDescription;
            } 
        }

        public string ServiceObjectVersion 
        { 
            get
            {
                return PosCommon.ServiceObjectVersion.ToString();
            } 
        }
        
        public bool Claimed 
        { 
            get
            {
                return PosCommon.Claimed;
            }
        }


        public bool DeviceEnabled 
        {
            get
            {
                return PosCommon.DeviceEnabled;
            }
            set
            {
                try
                {
                    PosCommon.DeviceEnabled = value;
                    RaisePropertyChanged("DeviceEnabled");
                }
                catch (Exception ex)
                {
                    ErrorOutput = PosCommon.LastException.ToString();
                }
            } 
        }

        public bool FreezeEvents
        {
            get
            {
                return PosCommon.FreezeEvents;
            }
            set
            {
                try
                {
                    PosCommon.FreezeEvents = value;
                    RaisePropertyChanged("FreezeEvents");
                }
                catch (Exception ex)
                {
                    ErrorOutput = PosCommon.LastException.ToString();
                }
            }
        }

        public string CheckHealthText
        {
            get
            {
                return PosCommon.CheckHealthText;
            }
        }
   
        public string State 
        {
            get
            {
                return PosCommon.State.ToString();
            }
        }

        public bool CanUpdateFirmware
        {
            get
            {
                return PosCommon.CapUpdateFirmware;
            }
        }

        public string PowerReportingSupport 
        { 
            get
            {
                return PosCommon.CapPowerReporting.ToString();
            }
        }
     
        public RelayCommand ClaimCommand { get; private set; }

        public RelayCommand ReleaseCommand { get; private set; }

        public RelayCommand CheckHealthCommand { get; private set; }

        public RelayCommand ClearErrorsCommand { get; private set; }
     
        public DeviceViewModel()
        {
            ClaimCommand = new RelayCommand(async () => await Claim());
            ReleaseCommand = new RelayCommand(() => Release());
            CheckHealthCommand = new RelayCommand(() => CheckHealth());
            ClearErrorsCommand = new RelayCommand(() => ClearErrors());
        }

        public void LoadData(DeviceInfo deviceInfo)
        {
            var posExplorer = new PosExplorer();
            PosCommon = posExplorer.CreateInstance(deviceInfo) as PosCommon;
            PosCommon.OpenDevice();

            PosCommon.StatusUpdateEvent += PosCommon_StatusUpdateEvent;
        }

        public async Task Claim()
        {
            var asyncOperation = PosCommon.ClaimDevice(1000);
            try
            {
                await asyncOperation.AsTask();
                RaisePropertyChanged("Claimed");        
            }
            catch (Exception ex)
            {
                
                ErrorOutput = ex.ToString();
            }
        }

        public void Release()
        {
            try
            {
                PosCommon.ReleaseDevice();
                RaisePropertyChanged("Claimed");
            }
            catch (Exception ex)
            {
                ErrorOutput = PosCommon.LastException.ToString();
            }

        }

        public void CheckHealth()
        {
            try
            {
                PosCommon.CheckHealth(HealthCheckLevel.Internal);
                RaisePropertyChanged("CheckHealthText");
            }
            catch (Exception ex)
            {
                ErrorOutput = PosCommon.LastException.ToString();
            }

        }


        public void ClearErrors()
        {
            ErrorOutput = string.Empty;
        }

        async void PosCommon_StatusUpdateEvent(object sender, StatusUpdateEventArgs e)
        {
            var coreWindowDispatcher = CoreApplication.MainView.CoreWindow.Dispatcher;
            await coreWindowDispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                UpdateSettings();
            }).AsTask();
        }

        public void UpdateSettings()
        {
            // fire property changed event(s) to requery state from PosCommon
             RaisePropertyChanged("DeviceEnabled");
             RaisePropertyChanged("State");
        }

        public override void Dispose()
        {
            if (PosCommon != null)
            {
                PosCommon.StatusUpdateEvent -= PosCommon_StatusUpdateEvent;
                PosCommon.CloseDevice();
            }
        }
    }
}
