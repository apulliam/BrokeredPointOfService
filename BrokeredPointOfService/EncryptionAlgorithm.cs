﻿// Brokered Point of Service ver. 1.0
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
    //     Enumerates the encryption algorithms supported by the device.
    public sealed class EncryptionAlgorithm : Enumeration
    {
        internal Microsoft.PointOfService.EncryptionAlgorithm InternalEncryptionAlgorithm { get; set; }

        internal EncryptionAlgorithm(Microsoft.PointOfService.EncryptionAlgorithm encryptionAlgorithm)
        {
            this.InternalEncryptionAlgorithm = encryptionAlgorithm;
        }

        // Summary:
        //     Data encryption is not supported.
        public static EncryptionAlgorithm None
        {
            get
            {
                return new EncryptionAlgorithm(Microsoft.PointOfService.EncryptionAlgorithm.None);
            }
        }

        //
        // Summary:
        //     Derived Unique Key Per Transaction (United States, Latin America).
        public static EncryptionAlgorithm TripleDeaDukpt
        {
            get
            {
                return new EncryptionAlgorithm(Microsoft.PointOfService.EncryptionAlgorithm.TripleDeaDukpt);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            EncryptionAlgorithm other = (EncryptionAlgorithm)obj;
            return this.InternalEncryptionAlgorithm.Equals(other.InternalEncryptionAlgorithm);
        }

        public override int GetHashCode()
        {
            return InternalEncryptionAlgorithm.GetHashCode();
        }

        public override string ToString()
        {
            return InternalEncryptionAlgorithm.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalEncryptionAlgorithm;
            }
        }
    }
}
