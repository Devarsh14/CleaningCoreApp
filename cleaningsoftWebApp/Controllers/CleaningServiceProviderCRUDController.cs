using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cleaningsoftWebApp.Models;

namespace cleaningsoftWebApp.Controllers
{
    
    public class CleaningServiceProviderCRUDController : Controller
    {
        private readonly CleaningSoftwareLogicContext cleaningSoftwareLogicContext;
        public CleaningServiceProviderCRUDController(CleaningSoftwareLogicContext cleaningSoftwareLogicContext)
        {
            this.cleaningSoftwareLogicContext = cleaningSoftwareLogicContext;
        }
        
        // Cleanign service providers controller home page
        public IActionResult Index()
        {
            IList<CleaningServiceProviders> cleaningServiceProvidersList = this.cleaningSoftwareLogicContext.CleaningServiceProviders.ToList();

            return View(cleaningServiceProvidersList);
        }
        public IActionResult Add (CleaningServiceProviders cleaningServiceProviders)
        {
            CleaningServiceProviders cleaningServiceProviders2 = new CleaningServiceProviders();
            cleaningServiceProviders2 = cleaningServiceProviders;
            


            this.cleaningSoftwareLogicContext.Add(cleaningServiceProviders2);
            this.cleaningSoftwareLogicContext.SaveChanges();

            return View();
        }

    }
}