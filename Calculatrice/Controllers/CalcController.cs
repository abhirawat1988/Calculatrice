using Calculatrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculatrice.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        public ActionResult Index()
        {
            return View(new calc());
        }
        [HttpPost]
        public ActionResult Index(calc c, string calculate)
        {
            if(calculate == "add")
            {
                c.result = c.number_1 + c.number_2;
            }
            else if (calculate == "min")
            {
                c.result = c.number_1 - c.number_2;
            }
            else if (calculate == "sub")
            {
                c.result = c.number_1 * c.number_2;
            }
            else
            {
                if (c.number_2 != 0)
                {
                    c.result = c.number_1 / c.number_2;
                }
                else
                {
                    c.result = 1234;
                }
            }
            return View(c);

        }
    }
}