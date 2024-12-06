using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ModelGroupWebApp.Models;

namespace ModelGroupWebApp.Controllers;

public class RaceController : Controller{

        public IActionResult Index(){
            return View();
        }


}