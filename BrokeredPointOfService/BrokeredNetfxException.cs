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
