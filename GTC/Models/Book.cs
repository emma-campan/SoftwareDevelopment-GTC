using System;


namespace Domain
{
 
    public class Book
    {

       
       // public int BookId { get; set; }

       
        public string ItemId { get; set; }


     
        public string ISBN { get; set; }


       
        public string Binding { get; set; }

       
        public string Edition { get; set; }

        public string SubjectArea { get; set; }

        //Item

       
        public string Title { get; set; }

       
        public int PublishDate { get; set; }

       
        public bool Rare { get; set; }

       
        public bool IsNeeded { get; set; }

        
        public int Available { get; set; }

       
        public int Copies { get; set; }

       
        public string Description { get; set; }
    }
}
