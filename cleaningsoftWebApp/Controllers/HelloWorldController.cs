using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cleaningsoftWebApp.Models;
namespace cleaningsoftWebApp.Controllers
{
    public class HelloWorldController :  Controller
    {
    public string Index()
        {
            return "I am Arya";
        }

}
}