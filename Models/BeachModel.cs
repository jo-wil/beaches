using System;

namespace MvcJoey.Models
{
    public class BeachModel
    {
        public int Id { get; set; }
    
        public string Name { get; set; }
   
        // Status = PERFECT | GREAT | GOOD | OKAY | BAD 
        public string Status { get; set; }
    }
}
