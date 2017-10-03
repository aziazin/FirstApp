using FirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApp.Controllers
{
    public class GameController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View(Game.ReadAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Game game)
        {
            Game.Create(game);
            return RedirectToAction("Index");
        }
    }
}