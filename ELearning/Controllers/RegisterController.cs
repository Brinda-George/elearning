using ELearning.Data;
using ELearning.Models;
using ELearning.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ELearning.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {

            Repository urep = new Repository();
            var temp = urep.CountryDrop();
            ViewBag.Country = new SelectList(temp);
            var temp1 = urep.Month();
            ViewBag.Month = new SelectList(temp1);
            var temp2 = urep.Day();
            ViewBag.Day = new SelectList(temp2);
            var temp3 = urep.Year();
            ViewBag.Year = new SelectList(temp3);
            return View();
        }
        public ActionResult CreateAccount(ELearning.View_Model.RegisterViewModel register)
        {
           
                Repository urep = new Repository();
                RegisterModel regim = new RegisterModel();
                regim.id = register.id;
                regim.firstName = register.firstName;
                regim.lastName = register.lastName;
                regim.username = register.username;
                regim.password = register.password;
                regim.country = register.country;
                regim.month = register.month;
                regim.day = register.day;
                regim.year = register.year;
                regim.gender = register.gender;
                regim.email = register.email;
                regim.phone = register.phone;
                urep.insert(regim);
                return View("Index");
           
        }
        public ActionResult Home(StartPage_ViewModel start)
        {
            TempData["user"] = start.username;
            Repository urep = new Repository();
            int temp = urep.login(start);
            var tech = urep.Technology();
            ViewBag.Technology = new SelectList(tech);
            if (temp == 2)
            {
                FormsAuthentication.SetAuthCookie(start.username, false);
                return View("HomePage");
            }
            else
            {
                Response.Write("<script>alert('Invalid Username Or Password')</script>");
                return View("Index");

            }
        }
        public ActionResult Search(string Technology)
        {
            Repository urep = new Repository();
            var temp = urep.Search(Technology);
            TempData["material1"] = "file:///" + temp.material1;
            TempData["material2"] = "file:///" + temp.material2;
            TempData["material3"] = "file:///" + temp.material3;
            TempData["material4"] = "file:///" + temp.material4;
            //Response.Write("<script>alert(temp)</script>");
            return PartialView("SearchPartial");
        }
        //public FileResult Download(string fileName)
        //{
        //    string filePath = @"~\Images\";
        //    string contentType = "application/ppt";
        //    //  string fileName = "myw3schoolsimage.jpg";
        //    filePath = Path.Combine(Server.MapPath(filePath), fileName);
        //    return File(filePath, contentType, fileName);
        //}
    }
}