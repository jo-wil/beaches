using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcJoey.Models;
using MvcJoey.Services;

namespace MvcJoey.Controllers
{
    public class JoeyController : Controller
    {
        private readonly IAccessLayer _accessLayer;
        private readonly ILogger<JoeyController> _logger;

        public JoeyController(IAccessLayer accessLayer, ILogger<JoeyController> logger)
        {
            _accessLayer = accessLayer;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var joeyViewModel = new JoeyViewModel()
            {
                Beaches = _accessLayer.ReadBeaches().ToList(),
                BeachStatuses = new List<string>()
                {
                    "PERFECT",
                    "GREAT",
                    "GOOD",
                    "OKAY",
                    "BAD" 
                }
            };
            return View(joeyViewModel);
        }
    
        [HttpPost]
        public IActionResult Update(JoeyViewModel joeyViewModel)
        {
            foreach (var beach in joeyViewModel.Beaches)
            {
                _logger.LogInformation(beach.Id.ToString());
                _logger.LogInformation(beach.Name);
                _logger.LogInformation(beach.Status);
            }
            _accessLayer.UpdateBeaches(joeyViewModel.Beaches);
            return Redirect("/Joey/Index"); 
        }
    }
}
