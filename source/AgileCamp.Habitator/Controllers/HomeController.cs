using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AgileCamp.Habitator.Models;

namespace AgileCamp.Habitator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      /// <summary>
      /// Добавление привычки
      /// </summary>
      /// <returns></returns>
       public ActionResult AddHabit()
       {
          
         return View();
       }

       [HttpPost]
      //       [AllowAnonymous]
      //       [ValidateAntiForgeryToken]
      public async Task<ActionResult> SubmitAdding(HabitModel model)
      {
         var habitModels = new List<HabitModel>();
         habitModels.Add(model);
         Session["Habits"] = habitModels;
         return RedirectToAction("Index", "Home");
      }

       //       [HttpPost]
         //       public ActionResult SubmitAdding(HabitModel model, string returnUrl)
         //       {
         //          return View();
         //
         //       }


      }
}