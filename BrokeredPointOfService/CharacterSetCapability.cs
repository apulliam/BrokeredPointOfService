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
    //     Enumerates the possible default character sets for a printer, line display,
    //     or point card reader/writer device.
    public sealed class CharacterSetCapability : Enumeration
    {
        internal Microsoft.PointOfService.CharacterSetCapability InternalCharacterSetCapability;

        internal CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability characterSetCapability)
        {
            InternalCharacterSetCapability = characterSetCapability;
        }

        // Summary:
        //     The default character set suports numeric data, plus space, minus, and period.
        //     (Line Display devices only.)
        public static CharacterSetCapability Numeric
        {
            get
            {
                return new CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability.Numeric);
            }
        }

        //
        // Summary:
        //     The default character set supports uppercase alphabetic plus numeric data,
        //     space, minus, and period.
        public static CharacterSetCapability Alpha
        {
            get
            {
                return new CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability.Alpha);
            }
        }

        //
        // Summary:
        //     The default character set supports partial code page 932. This includes ASCII
        //     characters 20-hex through 7F-hex and the Japanese kana characters A1-hex
        //     through DF-hex, but excluding the Japanese kanji characters.
        public static CharacterSetCapability Kana
        {
            get
            {
                return new CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability.Kana);
            }
        }

        //
        // Summary:
        //     The default character set supports code page 932, including the Shift-JIS
        //     kanji characters, Levels 1 and 2.
        public static CharacterSetCapability Kanji
        {
            get
            {
                return new CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability.Kanji);
            }
        }

        //
        // Summary:
        //     The default character set supports UNICODE.
        public static CharacterSetCapability Unicode
        {
            get
            {
                return new CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability.Unicode);
            }
        }

        //
        // Summary:
        //     The default character set supports all ASCII characters between 20-hex and
        //     7F-hex.
        public static CharacterSetCapability Ascii
        {
            get
            {
                return new CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability.Ascii);
            }
        }

        //
        // Summary:
        //     The default character set supports ANSI characters.
        public static CharacterSetCapability Windows
        {
            get
            {
                return new CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability.Windows);
            }
        }

        //
        // Summary:
        //     The default character set supports ANSI characters.
        public static CharacterSetCapability Ansi
        {
            get
            {
                return new CharacterSetCapability(Microsoft.PointOfService.CharacterSetCapability.Ansi);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            CharacterSetCapability other = (CharacterSetCapability)obj;
            return this.InternalCharacterSetCapability.Equals(other.InternalCharacterSetCapability);
        }

        public override int GetHashCode()
        {
            return InternalCharacterSetCapability.GetHashCode();
        }

        public override string ToString()
        {
            return InternalCharacterSetCapability.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalCharacterSetCapability;
            }
        }
    }
}
