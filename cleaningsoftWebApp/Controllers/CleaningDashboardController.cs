namespace cleaningsoftWebApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using cleaningsoftWebApp.Models;


    
    public class CleaningDashboardController : Controller
    {

        private readonly CleaningSoftwareLogicContext cleaningSoftwareLogicContext;
        public CleaningDashboardController(CleaningSoftwareLogicContext cleaningSoftwareLogicContext)
        {
            this.cleaningSoftwareLogicContext = cleaningSoftwareLogicContext;
        }
      // need to make a logic that we get required details from particular class
      // DTO 
      // ViewModel --> view model is best in this scenario 
      // than you can populate details 

        [HttpGet]
        [Route("api/TaskDashBoard")]
        public IActionResult TaskDetailForDash()
        {    CleaningSoftwareLogicContext dbcontext = new CleaningSoftwareLogicContext();
             var details=  this.cleaningSoftwareLogicContext.CleanerDetail
                             .GroupJoin(this.cleaningSoftwareLogicContext.CleaningTaskDetail,c=>c.Id,c=>c.CleanerDetailId,(CleanerDetail,CleaningTaskDetail)=>
                             new {cleanerName= CleanerDetail.CleanerDetailName,
                             CleaningTask=CleaningTaskDetail.Count()
                             });
             
           
             return new JsonResult(details);
        }


    }
}