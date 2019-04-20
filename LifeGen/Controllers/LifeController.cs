using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeGen.Models;
using LifeGenApi;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeGen.Controllers
{
    public class LifeController : Controller
    {
        public LifeGenEngine Engine { get; set; }
        public LifeController()
        {
            Engine = new LifeGenEngine();
        }
        public ActionResult Life()
        {
            return View(new LifeViewModel(Engine));
        }
        
        public ActionResult Sim()
        {
            Engine.Sim();
            //return View("Life", new LifeViewModel(Engine));
            return RedirectToAction("Life");
        }

        public ActionResult NewCharacter()
        {
            Engine.NewCharacter();
            return RedirectToAction("Life");
        }
    }
}