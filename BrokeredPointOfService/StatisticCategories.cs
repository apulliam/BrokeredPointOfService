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
    //     Lists the possible categories of device statistics that can be retrieved,
    //     reset, or updated.
    public sealed class StatisticCategories : Enumeration
    {
        internal Microsoft.PointOfService.StatisticCategories InternalStatisticCategories { get; set; }

        private StatisticCategories(Microsoft.PointOfService.StatisticCategories statisticCategories)
        {
            this.InternalStatisticCategories = statisticCategories;
        }
        // Summary:
        //     Unified POS-defined statistics.
        public static StatisticCategories Upos
        {
            get
            {
                return new StatisticCategories(Microsoft.PointOfService.StatisticCategories.Upos);
            }
        }
        //
        // Summary:
        //     Manufacturer-defined statistics.
        public static StatisticCategories Manufacturer
        {
            get
            {
                return new StatisticCategories(Microsoft.PointOfService.StatisticCategories.Manufacturer);
            }
        }
        //
        // Summary:
        //     All available statistics for the device.
        public static StatisticCategories All
        {
            get
            {
                return new StatisticCategories(Microsoft.PointOfService.StatisticCategories.All);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            StatisticCategories other = (StatisticCategories)obj;
            return this.InternalStatisticCategories.Equals(other.InternalStatisticCategories);
        }

        public override int GetHashCode()
        {
            return InternalStatisticCategories.GetHashCode();
        }

        public override string ToString()
        {
            return InternalStatisticCategories.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalStatisticCategories;
            }
        }
    }
}
