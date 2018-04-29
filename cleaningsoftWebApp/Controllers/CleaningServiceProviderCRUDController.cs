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
       // [HttpPost] Not at this stage -- In ajax will use only as a Post
        public IActionResult Add (CleaningServiceProviders cleaningServiceProviders)
        {
            // If model is empty or first attept made to go to add page it will go to view of add
            // If model is not empty means information has been added on to the add page it will execute add command and redirects to list or indiex page
            // Need to add a add button which redirecto to this action and view on to the List page so user can have a naviation path from list page for adding a new company otherwise have to redirect manually. 
            if (cleaningServiceProviders.CompanyName==null)
            {
                return View();
            }
            else
            {

                CleaningServiceProviders cleaningServiceProviders2 = new CleaningServiceProviders();
                cleaningServiceProviders2 = cleaningServiceProviders;
                this.cleaningSoftwareLogicContext.Add(cleaningServiceProviders2);
                this.cleaningSoftwareLogicContext.SaveChanges();

                return RedirectToAction("Index", "CleaningServiceProviderCRUD");
            }
            
        }

    }
}