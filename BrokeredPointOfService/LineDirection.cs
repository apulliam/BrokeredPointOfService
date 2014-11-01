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
    public sealed class LineDirection : Enumeration
    {
        internal Microsoft.PointOfService.LineDirection InternalLineDirection;

        internal LineDirection(Microsoft.PointOfService.LineDirection lineDirection)
        {
            InternalLineDirection = lineDirection;
        }

        public static LineDirection None
        {
            get
            {
                return new LineDirection(Microsoft.PointOfService.LineDirection.None);
            }
        }

        public static LineDirection Horizontal
        {
            get
            {
                return new LineDirection(Microsoft.PointOfService.LineDirection.Horizontal);
            }
        }

        public static LineDirection Vertical
        {
            get
            {
                return new LineDirection(Microsoft.PointOfService.LineDirection.Vertical);
            }
        }

        public static LineDirection HorizonatlVertical
        {
            get
            {
                return new LineDirection(Microsoft.PointOfService.LineDirection.Horizontal | Microsoft.PointOfService.LineDirection.Vertical);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            LineDirection other = (LineDirection)obj;
            return this.InternalLineDirection.Equals(other.InternalLineDirection);
        }

        public override int GetHashCode()
        {
            return InternalLineDirection.GetHashCode();
        }

        public override string ToString()
        {
            return InternalLineDirection.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalLineDirection;
            }
        }
    }
}
