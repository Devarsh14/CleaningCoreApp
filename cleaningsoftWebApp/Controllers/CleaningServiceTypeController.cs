using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cleaningsoftWebApp.Models;


namespace cleaningsoftWebApp.Controllers
{
    public class CleaningServiceTypeController : Controller
    {
        CleaningSoftwareLogicContext dbcontext = new CleaningSoftwareLogicContext();
        
       
        public IActionResult Index()
        {
            return new JsonResult(dbcontext.CleaningServiceType.ToList());
        }
        // [HttpGet("/api/cleaningServiceTypes")]

        public IActionResult home()
        {
            
            var cleaningservicetypes = dbcontext.CleaningServiceType.ToList();
            return View (cleaningservicetypes);
        }



    }
}


// In Mvc core we have only one controller 
// both type of controller are consolidated in one