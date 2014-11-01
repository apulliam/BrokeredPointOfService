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
   
    internal class BrokeredNetfxException : NetfxException
    {
        internal Exception InternalException { get; set; }

        internal BrokeredNetfxException(Exception exception)
        {
            InternalException = exception;
        }


        public System.Collections.Generic.IDictionary<string,string> Data
        {
            get { throw new NotImplementedException(); }
        }

        public string HelpLink
        {
            get
            {
                return InternalException.HelpLink;
            }
            set
            {
                InternalException.HelpLink = value;
            }
        }

        public int HResult
        {
            get
            {
                return InternalException.HResult;
            }
        }

        public NetfxException InnerException
        {
            get 
            { 
                return BrokeredNetfxExceptionFactory.CreateBrokeredException(InternalException.InnerException); 
            }
        }

        public string Message
        {
            get 
            { 
                return InternalException.Message; 
            }
        }

        public string Source
        {
            get
            {
                return InternalException.Source;
            }
            set
            {
                InternalException.Source = value;
            }
        }

        public string StackTrace
        {
            get 
            {
                return InternalException.StackTrace;
            }
        }

      
        public NetfxException GetBaseException()
        {
            return BrokeredNetfxExceptionFactory.CreateBrokeredException(InternalException.GetBaseException());
        }

        public override string ToString()
        {
            return InternalException.ToString();
        }

    }
}
