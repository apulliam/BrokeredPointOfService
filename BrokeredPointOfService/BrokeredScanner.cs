// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Windows.Foundation;

namespace BrokeredPointOfService
{
    internal class BrokeredScanner : BrokeredPosCommon, Scanner, IDisposable
    {
        // Summary:
        //     Incremented for each successful scan.
        internal const string StatisticGoodScanCount = "GoodScanCount";

        internal Microsoft.PointOfService.Scanner InternalScanner
        {
            get
            {
                return (Microsoft.PointOfService.Scanner)InternalPosDevice;
            }
        }


        internal BrokeredScanner(Microsoft.PointOfService.Scanner scanner) : base(scanner)
        {
            InternalScanner.DataEvent += InternalScanner_DataEvent;
            InternalScanner.ErrorEvent += InternalScanner_ErrorEvent;
        }

        void InternalScanner_ErrorEvent(object sender, Microsoft.PointOfService.DeviceErrorEventArgs e)
        {
            if (ErrorEvent != null)
                ErrorEvent(this, new DeviceErrorEventArgs(e));
        }

        void InternalScanner_DataEvent(object sender, Microsoft.PointOfService.DataEventArgs e)
        {
            if (DataEvent != null)
                DataEvent(this, new DataEventArgs(e));
        }

        public bool AutoDisable
        {
            get
            {
                return InternalScanner.AutoDisable;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalScanner.AutoDisable = value;
                    });
            }
        }

        public int DataCount
        {
            get 
            {
                return InternalScanner.DataCount;
            }
        }

        public bool DataEventEnabled
        {
            get
            {
                return InternalScanner.DataEventEnabled;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalScanner.DataEventEnabled = value;
                    });
            }
        }

        public bool DecodeData
        {
            get
            {
                return InternalScanner.DecodeData;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalScanner.DecodeData = value;
                    });
            }
        }

        public byte[] ScanData
        {
            get 
            {
                return InternalScanner.ScanData;
            }
        }

        public byte[] ScanDataLabel
        {
            get 
            {
                return InternalScanner.ScanDataLabel;
            }
        }

        public BarCodeSymbology ScanDataType
        {
            get 
            {
                return new BrokeredPointOfService.BarCodeSymbology(InternalScanner.ScanDataType);
            }
        }

        public event TypedEventHandler<Scanner,DataEventArgs> DataEvent;

        public event TypedEventHandler<Scanner, DeviceErrorEventArgs> ErrorEvent;

        public void ClearInput()
        {
            ExecuteAction(() =>
                {
                    InternalScanner.ClearInput();
                });
        }

        public void ClearInputProperties()
        {
            ExecuteAction(() =>
                {
                    InternalScanner.ClearInputProperties();
                });
        }

        public new void Dispose()
        {
            InternalScanner.DataEvent -= InternalScanner_DataEvent;
            InternalScanner.ErrorEvent -= InternalScanner_ErrorEvent;
            base.Dispose();
        }
    }
}
