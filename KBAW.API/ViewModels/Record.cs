using System;

namespace KBAW.API.ViewModels
{
    public class Record
    {
        public string Country { get; set; }
        
        public string Description { get; set; }
        
        public string Title { get; set; }
        
        public string Ydk { get; set; }
        
        public string? Classification { get; set; }
        
        public string? Number { get; set; }
        
        public string? PlacePublication { get; set; }
        
        public string? СertificateAuthorship { get; set; }
        
        public string[] Authors { get; set; }
    }
}