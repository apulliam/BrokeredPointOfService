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
