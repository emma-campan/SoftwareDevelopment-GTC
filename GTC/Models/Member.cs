using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Member
    {

        [DataMember]
        public int SSN { get; set; }

        [DataMember]
        public string Type { get; set; }


        [DataMember]
        public string Campus { get; set; }


        [DataMember]
        public DateTime RegistrationDate { get; set; }

        [DataMember]
        public DateTime ExpirationDate { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public byte[] IsStaff { get; set; }
    }
}
