using System;


namespace Domain
{

    public class Borrowing
    {

      
        public int BorrowingId { get; set; }

       
        public DateTime BorrowDate { get; set; }


     
        public DateTime DueDate { get; set; }


        public DateTime ActualReturnedDate { get; set; }

       
        public string Remarks { get; set; }


        public int SSN { get; set; }
        public string ItemId { get; set; }

        public bool Active { get; set; }

        public Member member { get; set; }

        public Book book { get; set; }


    }
}
