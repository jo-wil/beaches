using System;
using System.Collections.Generic;
using System.Linq;
using MvcJoey.Models;

namespace MvcJoey.Services
{
    public class AccessLayer : IAccessLayer
    {
        private IDictionary<int, BeachModel> _beachDatabase;
        public AccessLayer()
        {
            _beachDatabase = new Dictionary<int, BeachModel>();
            _beachDatabase.Add(1, new BeachModel() { Id = 1, Name = "Hermosa", Status = "GREAT" });
            _beachDatabase.Add(2, new BeachModel() { Id = 2, Name = "Malibu", Status = "OKAY" });
            _beachDatabase.Add(3, new BeachModel() { Id = 3, Name = "North Shore", Status = "PERFECT" });
        } 

        public ICollection<BeachModel> ReadBeaches()
        {
            return _beachDatabase.Values;
        }
        
        public void UpdateBeaches(ICollection<BeachModel> beaches)
        {
            foreach (var beachFromFrontend in beaches)
            {
                int beachFromFrontendId = beachFromFrontend.Id;
                if (_beachDatabase.ContainsKey(beachFromFrontendId))
                {
                    _beachDatabase[beachFromFrontendId].Status = beachFromFrontend.Status;
                }    
            }
        }
    }
} 
