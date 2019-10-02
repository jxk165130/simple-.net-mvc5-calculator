using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleWebCalculator.Models;

namespace SimpleWebCalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Index(Calculator calculator)
        {
           if(calculator.Operator == "+")
            {
                calculator.Result = calculator.FirstNumber + calculator.SecondNumber;
            }
           else if(calculator.Operator == "-")
            {
                calculator.Result = calculator.FirstNumber - calculator.SecondNumber;
            }
           else if(calculator.Operator == "*")
            {
                calculator.Result = calculator.FirstNumber * calculator.SecondNumber;
            }
            else
            {
                calculator.Result = calculator.FirstNumber / calculator.SecondNumber;
            }

            return View(calculator);
        }
        
        
    }
}