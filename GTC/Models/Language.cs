using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Language
    {

        [DataMember]
        public int LanguageId { get; set; }

        [DataMember]
        public string Languages { get; set; }


        [DataMember]
        public string ItemId { get; set; }

    }
}
