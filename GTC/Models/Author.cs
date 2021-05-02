using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Author
    {

        [DataMember]
        public int AuthorId { get; set; }

        [DataMember]
        public string ItemId { get; set; }


        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }


    }
}
