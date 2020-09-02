using System;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ThankYou(string firstname, string lastname, string email, string password) //Named the same as in HTML
        {

            Regex reg = new Regex(@"^[A-Za-z0-9]{1}[a-zA-Z0-9]{0,20}$");

            if (!reg.IsMatch(password))
            {
                System.Threading.Thread.Sleep(1000);
                return View("Error");
            }
            else
            {
                string hidePassword = "";
                foreach (char c in password)
                {
                    hidePassword += "*";
                }

                ViewBag.Welcome = $"Welcome,  {firstname} {lastname}!";
                ViewBag.ShowName = $"Email   : {email}";
                ViewBag.ShowPass = $"Password: {hidePassword}";

                return View();
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}