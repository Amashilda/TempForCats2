using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TempForCats2.Models;

namespace TempForCats2.Controllers
{
    public class LoginsController : Controller
    {
          public ActionResult Index()
        {
            return View();
        }

          public ActionResult Logining(LoginModel mod)
          {
              Dao DaoLog = new Dao();
              LoginModel LogMod = DaoLog.getCredentials();
              if (mod.Login.Equals(LogMod.Login) && mod.Login.Equals(LogMod.Password))
                  return View();
              return View();
              
          }

    }
}
