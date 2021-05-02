using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Phone
    {

        [DataMember]
        public int PhoneId { get; set; }

        [DataMember]
        public int PhoneNo { get; set; }


        [DataMember]
        public int SSN { get; set; }

    }
}
