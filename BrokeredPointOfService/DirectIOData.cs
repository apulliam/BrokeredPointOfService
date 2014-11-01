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
    //     Defines the programmatic structure the service object uses to return data
    //     to an application.
    public sealed class DirectIOData
    {
        internal Microsoft.PointOfService.DirectIOData InternalDirectIOData { get; set; }

        internal DirectIOData(Microsoft.PointOfService.DirectIOData directIOData)
        {
            InternalDirectIOData = directIOData;
        }

        //
        // Summary:
        //     Creates an instance of the DirectIOData structure with the specified data.
        //
        // Parameters:
        //   obj:
        //     An object.
        //
        //   data:
        //     Integer data.
        public DirectIOData(int data, object obj)
        {
            InternalDirectIOData = new Microsoft.PointOfService.DirectIOData(data, obj);
        }
  
        public int Data 
        {
            get
            {
                return InternalDirectIOData.Data;
            }
        }
        public object Object 
        {
            get
            {
                return InternalDirectIOData.Object;
            }
        }

        // Summary:
        //     Determines whether the specified Microsoft.PointOfService.DirectIOData is
        //     equal to the current Microsoft.PointOfService.DirectIOData.
        //
        // Parameters:
        //   d:
        //     The Microsoft.PointOfService.DirectIOData object to be compared to the current
        //     Microsoft.PointOfService.DirectIOData.
        //
        // Returns:
        //     A Boolean value that is true if the two instances are equal; otherwise, the
        //     value is false.
        public bool Equals(DirectIOData d)
        {
            return InternalDirectIOData.Equals(d);
        }
        //
        // Summary:
        //     Determines whether the specified Object is equal to the current Microsoft.PointOfService.DirectIOData.
        //
        // Parameters:
        //   obj:
        //     The object to be compared with the current Microsoft.PointOfService.DirectIOData.
        //
        // Returns:
        //     True if the specified object is equal to the current Microsoft.PointOfService.DirectIOData;
        //     otherwise, false.
        public bool EqualsObject(object obj)
        {
            return InternalDirectIOData.Equals(obj);
        }
      
        //
        // Summary:
        //     Returns the hash code of the current Microsoft.PointOfService.DirectIOData.
        //
        // Returns:
        //     An Int32 representation of the hash code for the current Microsoft.PointOfService.DirectIOData.
        public override int GetHashCode()
        {
            return InternalDirectIOData.GetHashCode();
        }
        //
        // Summary:
        //     Returns a string representation of the Microsoft.PointOfService.DirectIOData
        //     instance.
        //
        // Returns:
        //     A string representation of the Microsoft.PointOfService.DirectIOData.
        public override string ToString()
        {
            return InternalDirectIOData.ToString();
        }
    }
}
