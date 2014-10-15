using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace BrokeredPointOfService
{
    public sealed class PosExplorer : IDisposable
    {
        internal Microsoft.PointOfService.PosExplorer InternalPosExplorer { get; set; }

        public PosExplorer()
        {
            InternalPosExplorer = new Microsoft.PointOfService.PosExplorer();
            InternalPosExplorer.DeviceAddedEvent +=InternalPosExplorer_DeviceAddedEvent;
            InternalPosExplorer.DeviceRemovedEvent += InternalPosExplorer_DeviceRemovedEvent;
        }

        public static string PosRegistryKey
        {
            get 
            {
                return Microsoft.PointOfService.PosExplorer.PosRegistryKey; 
            }
        }

        public static string StatisticsFile
        {
            get 
            {
                return Microsoft.PointOfService.PosExplorer.StatisticsFile;
            }
        }

        public event TypedEventHandler<PosExplorer, DeviceChangedEventArgs> DeviceAddedEvent;

        public event TypedEventHandler<PosExplorer, DeviceChangedEventArgs> DeviceRemovedEvent;


        void InternalPosExplorer_DeviceAddedEvent(object sender, Microsoft.PointOfService.DeviceChangedEventArgs e)
        {
            if (DeviceAddedEvent != null)
                DeviceAddedEvent(this, new DeviceChangedEventArgs(e));
        }
        void InternalPosExplorer_DeviceRemovedEvent(object sender, Microsoft.PointOfService.DeviceChangedEventArgs e)
        {
            if (DeviceRemovedEvent != null)
                DeviceRemovedEvent(this, new DeviceChangedEventArgs(e));
        }

        public PosDevice CreateInstance(DeviceInfo device)
        {
            return PosDeviceFactory.CreatedBrokeredPosDevice(InternalPosExplorer, device.InternalDeviceInfo);
        }

        public DeviceInfo GetDeviceByType(string type)
        {
            return new DeviceInfo(InternalPosExplorer.GetDevice(type));
        }

        public DeviceInfo GetDeviceByTypeAndLogicalName(string type, string logicalName)
        {
            return new DeviceInfo(InternalPosExplorer.GetDevice(type, logicalName));
        }

        public DeviceInfo[] GetDevices()
        {
           return ToDeviceInfoArray(InternalPosExplorer.GetDevices());
        }

        public DeviceInfo[] GetDevicesByCompatibilities(DeviceCompatibilities compatibility)
        {
            return ToDeviceInfoArray(InternalPosExplorer.GetDevices(compatibility.InternalDeviceCompatibilities));
        }

        public DeviceInfo[] GetDevicesByType(string type)
        {
            return ToDeviceInfoArray(InternalPosExplorer.GetDevices(type));
        }

        public DeviceInfo[] GetDevices(string type, DeviceCompatibilities compatibility)
        {
            return ToDeviceInfoArray(InternalPosExplorer.GetDevices(type, compatibility.InternalDeviceCompatibilities));
        }

        public void Refresh()
        {
            InternalPosExplorer.Refresh();
        }

        private DeviceInfo[] ToDeviceInfoArray(Microsoft.PointOfService.DeviceCollection deviceCollection)
        {
            var deviceInfoList = new List<DeviceInfo>();
            foreach (Microsoft.PointOfService.DeviceInfo device in deviceCollection)
            {
                deviceInfoList.Add(new DeviceInfo(device)); 
            }
            return deviceInfoList.ToArray();
        }
     
        public void Dispose()
        {
            InternalPosExplorer.DeviceAddedEvent -= InternalPosExplorer_DeviceAddedEvent;
            InternalPosExplorer.DeviceRemovedEvent -= InternalPosExplorer_DeviceRemovedEvent;
        }
    }
}
