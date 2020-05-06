using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqrtApp.Models;

namespace SqrtApp.Controllers
{
    public class SqrtController : Controller
    {
        public const string V = "Square roots are the same. Please try again";
        public const string V1 = "Input not a number! Put in a correct number format!";
        public const string V2 = "Error: Input positive numbers";

        [HttpGet]
        public ActionResult IsSqrtGreater()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IsSqrtGreater(string firstNumber, string secondNumber)
        {
            double firstNum;
            double secondNum;

            var firstNumberString = firstNumber;
            var secondNumberString = secondNumber;
           

            if (double.TryParse(firstNumber, out firstNum) && double.TryParse(firstNumber, out secondNum))
            {
                
                firstNum = double.Parse(firstNumber);
                secondNum = double.Parse(secondNumber);
                

                var firstNumSqrt = Math.Sqrt(firstNum);
                var secondNumSqrt = Math.Sqrt(secondNum);

                ViewBag.FirstNumSqrt = firstNumSqrt;
                ViewBag.SecondNumSqrt = secondNumSqrt;
                ViewBag.FirstNum = firstNum;
                ViewBag.SecondNum = secondNum;
                ViewBag.Err1 = V;
                ViewBag.Err2 = V1;
                ViewBag.Err3 = V2;
            }
            else
            {
                ViewBag.FirstNumberString  = firstNumberString;
                ViewBag.SecondNumberString = secondNumberString;
            }

            return View();
        }

    }
}
