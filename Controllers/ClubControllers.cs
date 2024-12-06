using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelGroupWebApp.Models;

namespace ModelGroupWebApp.Controllers;

public class ClubController : Controller{

        public IActionResult Index(){
            return View();
        }


}