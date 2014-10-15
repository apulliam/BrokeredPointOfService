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
