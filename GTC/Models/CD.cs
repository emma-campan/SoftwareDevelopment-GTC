using System;


namespace Domain
{

    public class CD
    {

    
        //public int CdId { get; set; }


        public string ItemId { get; set; }


     
        public DateTime Duration { get; set; }


        //Item

    
        public string Title { get; set; }

     
        public int PublishDate { get; set; }

      
        public byte[] Rare { get; set; }

     
        public byte[] IsNeeded { get; set; }

      
        public int Available { get; set; }

     
        public int Copies { get; set; }

      
        public string Description { get; set; }
    }
}
