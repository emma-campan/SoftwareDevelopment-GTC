using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Magazine
    {

        [DataMember]
        public int MagazineId { get; set; }

        [DataMember]
        public string ItemId { get; set; }


        [DataMember]
        public string SubjectArea { get; set; }


        //Item

        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public int PublishDate { get; set; }

        [DataMember]
        public byte[] Rare { get; set; }

        [DataMember]
        public byte[] IsNeeded { get; set; }

        [DataMember]
        public int Available { get; set; }

        [DataMember]
        public int Copies { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
