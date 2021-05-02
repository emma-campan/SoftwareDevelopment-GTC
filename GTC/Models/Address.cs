using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Address
    {

        [DataMember]
        public int AddressId { get; set; }

        [DataMember]
        public string Addresses { get; set; }


        [DataMember]
        public int SSN { get; set; }

    }
}
