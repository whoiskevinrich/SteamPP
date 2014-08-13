using SteamPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SteamPP.Web.Controllers
{
    public class UserController : Controller
    {
        public UserController()
        {
            var _service = new Steam.Query.MasterServer();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Library()
        {
            var model = new GameModels();



            return View(model);
        }
    }
}