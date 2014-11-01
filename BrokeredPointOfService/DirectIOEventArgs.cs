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
    //     Defines the programmatic interface for the transmission of Direct IO Events.
    public sealed class DirectIOEventArgs 
    {
        internal Microsoft.PointOfService.DirectIOEventArgs InternalDirectIOEventArgs { get; set; }

        internal DirectIOEventArgs(Microsoft.PointOfService.DirectIOEventArgs directIOEventArgs)
        {
            InternalDirectIOEventArgs = directIOEventArgs;
        }

        public int Data
        {
            get
            {
                return InternalDirectIOEventArgs.Data;
            }
            set
            {
                InternalDirectIOEventArgs.Data = value;
            }
        }
        
        public int EventNumber 
        {
            get
            {
                return InternalDirectIOEventArgs.EventNumber;
            }
        }
        
        public object Object 
        {
            get
            {
                return InternalDirectIOEventArgs.Object;
            }
            set
            {
                InternalDirectIOEventArgs.Object = value;
            }
        }

        public override string ToString()
        {
            return InternalDirectIOEventArgs.ToString();
        }
    }
}
