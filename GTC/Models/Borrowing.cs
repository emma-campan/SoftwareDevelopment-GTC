using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Borrowing
    {

        [DataMember]
        public int BorrowingId { get; set; }

        [DataMember]
        public DateTime BorrowDate { get; set; }


        [DataMember]
        public DateTime DueDate { get; set; }


        [DataMember]
        public DateTime ActualReturnedDate { get; set; }

        [DataMember]
        public string Remarks { get; set; }

        [DataMember]
        public string ItemId { get; set; }

        [DataMember]
        public int SSN { get; set; }
    }
}
