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
    //     Enumerates the valid compatibility levels for a POS device.
    public sealed class DeviceCompatibilities : Enumeration
    {
         internal DeviceCompatibilities(Microsoft.PointOfService.DeviceCompatibilities value)
         {
              this.InternalDeviceCompatibilities = value;
         }

         internal Microsoft.PointOfService.DeviceCompatibilities InternalDeviceCompatibilities { get; set; }


         // Summary:
         //     Indicates compatibility with any COM service object.
         public static DeviceCompatibilities Opos 
         { 
             get 
             {
                 return new DeviceCompatibilities(Microsoft.PointOfService.DeviceCompatibilities.Opos); 
             } 
         }

         //
         // Summary:
         //     Indicates compatibility with any .NET service object.
         public static DeviceCompatibilities CompatibilityLevel1 
         { 
             get 
             {
                 return new DeviceCompatibilities(Microsoft.PointOfService.DeviceCompatibilities.CompatibilityLevel1); 
             } 
         }

        //
        // Summary:
        //     Indicates compatibility with any .NET or COM service object.
        public static DeviceCompatibilities OposAndCompatibilityLevel1
        {
            get
            {
                return new DeviceCompatibilities(Microsoft.PointOfService.DeviceCompatibilities.OposAndCompatibilityLevel1);
            }
        }
 
         public override bool Equals(object obj)
         {
             if (obj == null) 
                 return false;

             DeviceCompatibilities other = (DeviceCompatibilities)obj;
             return this.InternalDeviceCompatibilities.Equals(other.InternalDeviceCompatibilities);
         }

         public override int GetHashCode()
         {
             return InternalDeviceCompatibilities.GetHashCode();
         }

         public override string ToString()
         {
             return InternalDeviceCompatibilities.ToString();
         }

         public int Value
         {
             get
             {
                 return (int)InternalDeviceCompatibilities;
             }
         }
    }
}
