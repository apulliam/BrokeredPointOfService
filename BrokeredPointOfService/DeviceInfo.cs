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
