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
        
       
        [HttpGet]
         [Route("api/ServiceTypeApi")] 
        public IActionResult ServiceTypeApi()
        {
            return new JsonResult(dbcontext.CleaningServiceType.ToList());
        }
        // [HttpGet("/api/cleaningServiceTypes")]

        public IActionResult home()
        {
            int a; int ha; int ah; int ya; int ea;

            var cleaningservicetypes = dbcontext.CleaningServiceType.ToList();
            return View ();
        }



    }
}


// In Mvc core we have only one controller 
// both type of controller are consolidated in one