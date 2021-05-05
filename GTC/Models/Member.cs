using System;


namespace Domain
{
    
    public class Member
    {

      
        public int SSN { get; set; }

       
        public string Type { get; set; }


       
        public string Campus { get; set; }


        public DateTime RegistrationDate { get; set; }

       
        public DateTime ExpirationDate { get; set; }

        
        public string Password { get; set; }

       
        public byte[] IsStaff { get; set; }
    }
}
