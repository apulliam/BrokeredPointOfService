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
    //     Enumerates the valid comparison results between firmware files.
    public sealed class CompareFirmwareResult : Enumeration
    {
        internal Microsoft.PointOfService.CompareFirmwareResult InternalCompareFirmwareResult { get; set; }

        internal CompareFirmwareResult(Microsoft.PointOfService.CompareFirmwareResult compareFirmwareResult)
        {
            this.InternalCompareFirmwareResult = compareFirmwareResult;
        }
        
        // Summary:
        //     Indicates that the version of one or more of the firmware files is older
        //     than the firmware in the device and that none of the firmware files is newer
        //     than the firmware in the device.
        public static CompareFirmwareResult Older
        {
            get
            {
                return new CompareFirmwareResult(Microsoft.PointOfService.CompareFirmwareResult.Older);
            }
        }

        //
        // Summary:
        //     Indicates that the versions of all of the firmware files are the same as
        //     the firmware in the device.
        public static CompareFirmwareResult Same      
        {
            get
            {
                return new CompareFirmwareResult(Microsoft.PointOfService.CompareFirmwareResult.Same);
            }
        }
        
        //
        // Summary:
        //     Indicates that the version of one or more of the firmware files is newer
        //     than the firmware in the device and that none of the firmware files is older
        //     than the firmware in the device.
        public static CompareFirmwareResult Newer
        {
            get
            {
                return new CompareFirmwareResult(Microsoft.PointOfService.CompareFirmwareResult.Newer);
            }
        }        
        
        //
        // Summary:
        //     Indicates that the version of one or more of the firmware files is different
        //     than the firmware in the device, but either:
        public static CompareFirmwareResult Different
        {
            get
            {
                return new CompareFirmwareResult(Microsoft.PointOfService.CompareFirmwareResult.Different);
            }
        }
        
        //
        // Summary:
        //     Indicates that a relationship between the two firmware versions could not
        //     be determined. A possible reason for this result could be an attempt to compare
        //     Japanese and US versions of firmware.
        public static CompareFirmwareResult Unknown
        {
            get
            {
                return new CompareFirmwareResult(Microsoft.PointOfService.CompareFirmwareResult.Unknown);
            }
        }

        public override bool Equals(object obj)
        {
             if (obj == null) 
                 return false;

             CompareFirmwareResult other = (CompareFirmwareResult)obj;
             return this.InternalCompareFirmwareResult.Equals(other.InternalCompareFirmwareResult);
         }

        public override int GetHashCode()
        {
            return InternalCompareFirmwareResult.GetHashCode();
        }

        public override string ToString()
        {
            return InternalCompareFirmwareResult.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalCompareFirmwareResult;
            }
        }
    }
}
