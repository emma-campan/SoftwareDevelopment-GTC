using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class CD
    {

        [DataMember]
        public int CdId { get; set; }

        [DataMember]
        public string ItemId { get; set; }


        [DataMember]
        public DateTime Duration { get; set; }


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
