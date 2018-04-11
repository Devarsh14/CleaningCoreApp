using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cleaningsoftWebApp.Model;

namespace cleaningsoftWebApp.Controllers
{
    public class CleaningServiceTypeController : Controller
    {
        CleaningSoftwareLogicContext dbcontext = new CleaningSoftwareLogicContext();
        
        [HttpGet("/api/cleaningServiceTypes")]
        public IActionResult Index()
        {
            var cleaningservicetypes = dbcontext.CleaningServiceType.ToList();
            return new JsonResult(cleaningservicetypes);
        }

        
        public IActionResult home()
        {
            var cleaningservicetypes = dbcontext.CleaningServiceType.ToList();
            return View (cleaningservicetypes);
        }



    }
}


// In Mvc core we have only one controller 
// both type of controller are consolidated in one