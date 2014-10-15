using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    public sealed class DeviceInfo 
    {
        internal Microsoft.PointOfService.DeviceInfo InternalDeviceInfo { get; set; }

        internal DeviceInfo(Microsoft.PointOfService.DeviceInfo deviceInfo)
        {
            InternalDeviceInfo = deviceInfo;
        }

        // Summary:
        //     Gets device compatibility information.
        public DeviceCompatibilities Compatibility 
        {
            get
            {
                return new DeviceCompatibilities(InternalDeviceInfo.Compatibility);
            }
        }
        
        public string Description 
        { 
            get
            {
                return InternalDeviceInfo.Description;
            }
        }

        public string HardwareDescription 
        { 
            get
            {
                return InternalDeviceInfo.HardwareDescription;
            }
        }

        public string HardwareId 
        {
            get
            {
                return InternalDeviceInfo.HardwareId;
            }
        }

        public string HardwarePath 
        {
            get
            {
                return InternalDeviceInfo.HardwarePath;
            }
        }
        
        public bool IsDefault 
        {
            get
            {
                return InternalDeviceInfo.IsDefault;
            }
        }

        public string[] LogicalNames 
        { 
            get
            {
                return InternalDeviceInfo.LogicalNames;
            }
        }

        public string ManufacturerName
        {
            get
            {
                return InternalDeviceInfo.ManufacturerName;
            }
        }
        
        public string ServiceObjectName 
        {
            get
            {
                return InternalDeviceInfo.ServiceObjectName;
            }
        }

        public Version ServiceObjectVersion 
        {
            get
            {
                return new Version(InternalDeviceInfo.ServiceObjectVersion);
            }
        }

        public string Type 
        {
            get
            {
                return InternalDeviceInfo.Type;
            }
        }

        public Version UposVersion 
        {
            get
            {
                return new Version(InternalDeviceInfo.UposVersion);
            }
        }

        public override bool Equals(object obj)
        {
            return InternalDeviceInfo.Equals(obj);
        }

        public override int GetHashCode()
        {
            return InternalDeviceInfo.GetHashCode();
        }
       
        //
        // Summary:
        //     Gets the Boolean value that indicates whether a DeviceInfo instance applies
        //     to the specified service object.
        //
        // Parameters:
        //   serviceObject:
        //     The service object to compare.
        bool IsDeviceInfoOf(PosCommon serviceObject)
        {
            var brokeredPosCommon = (BrokeredPosCommon)serviceObject;
            return InternalDeviceInfo.IsDeviceInfoOf((Microsoft.PointOfService.PosCommon)brokeredPosCommon.InternalPosCommon);
        }

        public override string ToString()
        {
            return InternalDeviceInfo.ToString();
        }
    }
}
