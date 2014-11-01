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
    // Summary:
    //     Enumerates the level of device authentication supported by the service.
    public sealed class DeviceAuthenticationLevel : Enumeration
    {
        internal Microsoft.PointOfService.DeviceAuthenticationLevel InternalDeviceAuthenticationLevel { get; set; }

        internal DeviceAuthenticationLevel(Microsoft.PointOfService.DeviceAuthenticationLevel deviceAuthenticationLevel)
        {
            this.InternalDeviceAuthenticationLevel = deviceAuthenticationLevel;
        }

        // Summary:
        //     The service does not support device authentication.
        public static DeviceAuthenticationLevel NotSupported
        {
            get
            {
                return new DeviceAuthenticationLevel(Microsoft.PointOfService.DeviceAuthenticationLevel.NotSupported);
            }
        }
        
        //
        // Summary:
        //     The service supports device authentication, but does not require it.
        public static DeviceAuthenticationLevel Optional
        {
            get
            {
                return new DeviceAuthenticationLevel(Microsoft.PointOfService.DeviceAuthenticationLevel.Optional);
            }
        }

        //
        // Summary:
        //     The service requires device authentication.
        public static DeviceAuthenticationLevel Required
        {
            get
            {
                return new DeviceAuthenticationLevel(Microsoft.PointOfService.DeviceAuthenticationLevel.Required);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) 
                return false;

            DeviceAuthenticationLevel other = (DeviceAuthenticationLevel)obj;
            return this.InternalDeviceAuthenticationLevel.Equals(other.InternalDeviceAuthenticationLevel);
        }

        public override int GetHashCode()
        {
            return InternalDeviceAuthenticationLevel.GetHashCode();
        }

        public override string ToString()
        {
            return InternalDeviceAuthenticationLevel.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalDeviceAuthenticationLevel;
            }
        }
    }
}
