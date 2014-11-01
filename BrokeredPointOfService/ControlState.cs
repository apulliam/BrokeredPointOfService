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
    //     Enumerates the valid states of a device.
    public sealed class ControlState : Enumeration
    {
        internal Microsoft.PointOfService.ControlState InternalControlState { get; set; }

        internal ControlState(Microsoft.PointOfService.ControlState controlState)
        {
            this.InternalControlState = controlState;
        }

        // Summary:
        //     The device is closed. The service object is not initialized.
        public static ControlState Closed
        {
            get
            {
                return new ControlState(Microsoft.PointOfService.ControlState.Closed);
            }
        }

        //
        // Summary:
        //     The device is in a good state and is not busy.
        public static ControlState Idle
        {
            get
            {
                return new ControlState(Microsoft.PointOfService.ControlState.Idle);
            }
        }

        //
        // Summary:
        //     The device is in a good state and is busy performing output.
        public static ControlState Busy
        {
            get
            {
                return new ControlState(Microsoft.PointOfService.ControlState.Busy);
            }
        }
        //
        // Summary:
        //     An error has been reported, and the application must recover the Control
        //     to a good state before normal I/O can resume.
        public static ControlState Error
        {
            get
            {
                return new ControlState(Microsoft.PointOfService.ControlState.Error);
            }
        }

         public override bool Equals(object obj)
         {
             if (obj == null) 
                 return false;

             ControlState other = (ControlState)obj;
             return this.InternalControlState.Equals(other.InternalControlState);
         }

         public override int GetHashCode()
         {
             return InternalControlState.GetHashCode();
         }

         public override string ToString()
         {
             return InternalControlState.ToString();
         }

         public int Value
         {
             get
             {
                 return (int)InternalControlState;
             }
         }
       
    }
}
