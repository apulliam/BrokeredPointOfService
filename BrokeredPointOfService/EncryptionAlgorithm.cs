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
