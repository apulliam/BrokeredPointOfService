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
    public sealed class Version
    {
        internal System.Version InternalVersion { get; set; }

        internal Version(System.Version version)
        {
            this.InternalVersion = version;
        }

        public int Build
        {
            get 
            {
                return InternalVersion.Build;
            }
        }

        public int Major
        {
            get 
            {
                return InternalVersion.Major;
            }
        }

        public short MajorRevision
        {
            get 
            {
                return InternalVersion.MajorRevision; 
            }
        }

        public int Minor
        {
            get 
            {
                return InternalVersion.Minor; 
            }
        }

        public short MinorRevision
        {
            get 
            { 
                return InternalVersion.MinorRevision;
            }
        }

        public int Revision
        {
            get 
            {
                return InternalVersion.Revision; 
            }
        }

        public object Clone()
        {
            return InternalVersion.Clone();
        }

        public int CompareToObject(object obj)
        {
            return InternalVersion.CompareTo(obj);
        }

        public int CompareTo(Version other)
        {
            return InternalVersion.CompareTo(other);
        }

        public bool EqualsObject(object obj)
        {
            return InternalVersion.Equals(obj);
        }

        public bool Equals(Version other)
        {
            return InternalVersion.Equals(other);
        }

        public string ToString(int fieldCount)
        {
            return InternalVersion.ToString(fieldCount);
        }
        public override string ToString()
        {
            return InternalVersion.ToString();
        }
    }
}
