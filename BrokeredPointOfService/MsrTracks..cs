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
    //     Lists the possible combinations of track data to be read.
    public sealed class MsrTracks : Enumeration
    {
        internal Microsoft.PointOfService.MsrTracks InternalMsrTracks;

        internal MsrTracks(Microsoft.PointOfService.MsrTracks msrTracks)
        {
            this.InternalMsrTracks = msrTracks;
        }

        // Summary:
        //     No track will be obtained.
        public static MsrTracks None
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.None);
            }
        }

        //
        // Summary:
        //     Obtain track 1.
        public static MsrTracks Track1
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Track1);
            }
        }

        //
        // Summary:
        //     Obtain track 2.
        public static MsrTracks Track2
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Track2);
            }
        }

        //
        // Summary:
        //     Obtain tracks 1 and 2.
        public static MsrTracks Tracks12
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks12);
            }
        }

        //
        // Summary:
        //     Obtain track 3.
        public static MsrTracks Track3
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Track3);
            }
        }

        //
        // Summary:
        //     Obtain tracks 1 and 3.
        public static MsrTracks Tracks13
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks13);
            }
        }

        //
        // Summary:
        //     Obtain tracks 2 and 3.
        public static MsrTracks Tracks23
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks23);
            }
        }

        //
        // Summary:
        //     Obtain tracks 1, 2, and 3.
        public static MsrTracks Tracks123
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks123);
            }
        }

        //
        // Summary:
        //     Obtain track 4.
        public static MsrTracks Track4
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Track4);
            }
        }

        //
        // Summary:
        //     Obtain tracks 1 and 4.
        public static MsrTracks Tracks14
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks14);
            }
        }

        //
        // Summary:
        //     Obtain tracks 2 and 4.
        public static MsrTracks Tracks24
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks24);
            }
        }

        //
        // Summary:
        //     Obtain tracks 1, 2, and 4.
        public static MsrTracks Tracks124
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks124);
            }
        }

        //
        // Summary:
        //     Obtain tracks 3 and 4.
        public static MsrTracks Tracks34
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks34);
            }
        }

        //
        // Summary:
        //     Obtain tracks 1, 3, and 4.
        public static MsrTracks Tracks134
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks134);
            }
        }

        //
        // Summary:
        //     Obtain tracks 2, 3, and 4.
        public static MsrTracks Tracks234
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks234);
            }
        }

        //
        // Summary:
        //     Obtain tracks 1, 2, 3, and 4.
        public static MsrTracks Tracks1234
        {
            get
            {
                return new MsrTracks(Microsoft.PointOfService.MsrTracks.Tracks1234);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MsrTracks other = (MsrTracks)obj;
            return this.InternalMsrTracks.Equals(other.InternalMsrTracks);
        }

        public override int GetHashCode()
        {
            return InternalMsrTracks.GetHashCode();
        }

        public override string ToString()
        {
            return InternalMsrTracks.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalMsrTracks;
            }
        }
    }
}
