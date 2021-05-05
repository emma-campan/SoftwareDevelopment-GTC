using System;


namespace Domain
{
    
    public class VideoGame
    {

       
       // public int VideoGameId { get; set; }

       
        public string ItemId { get; set; }


        public string Developer { get; set; }

      
        public string Genre { get; set; }

   


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
