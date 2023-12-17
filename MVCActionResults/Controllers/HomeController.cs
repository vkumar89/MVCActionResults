using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCActionResults.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            return View();
        }
       
        public ViewResult Resister()
        {
            return View();
        }
        public ViewResult ForgotPassword()
        {
            return View("ForgotPwd");
        }
        public ViewResult ResetPassword()
        {
            return View("~/Views/Home/ResetPwd.cshtml");
        }
        public ViewResult Contact()
        {
            return View();
        }
        public ViewResult Mission()
        {
            return View("~/Views/Test/Mission.cshtml");
        }
        public ViewResult About()
        {
            return View("~/View/Home/About");
        }
        public ViewResult show(int id)
        {
            if (id == 1)
            {
                return View("Show1");
            }
            else
            {
                return View("Show2");
            }
        }
        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public string Login(string user)
        {
            return "valid user"+ user;
        }
    }
}