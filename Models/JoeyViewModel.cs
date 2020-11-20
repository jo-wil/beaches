using System;
using System.Collections.Generic;

namespace MvcJoey.Models
{
    public class JoeyViewModel
    {
        public IList<BeachModel> Beaches { get; set; }

        public IList<string> BeachStatuses { get; set; }      
    }
}
