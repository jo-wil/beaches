using System;
using System.Collections.Generic;
using System.Linq;
using MvcJoey.Models;

namespace MvcJoey.Services
{
    public interface IAccessLayer
    {
        public ICollection<BeachModel> ReadBeaches();
        public void UpdateBeaches(ICollection<BeachModel> beaches);
    }
} 
