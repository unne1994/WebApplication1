using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index(Class1 result)
        {
            
            //    result.category = "1111";
            //result.date = DateTime.Parse("5 / 1 / 2008 8:30:52 AM");
            Random ra = new Random();
            List<Class1> list = new List<Class1>();
            for (int i = 1; i <= 100; i++)
            {
                var resultincom = "";

                //var days = ra.Next(1000);
                //var datt = DateTime.Now.AddDays(days);

                var AmountOfMoneys = ra.Next(1000000);

                var datt = DateTime.Now.AddMilliseconds(AmountOfMoneys).AddDays(AmountOfMoneys);

                var income = ra.Next(2)+1;
                if (income == 1)
                {
                    resultincom = "收入";
                }
                else
                {
                    resultincom = "支出";
                }

                list.Add(new Class1 { category  = resultincom, date= datt , AmountOfMoney = AmountOfMoneys,water=i});
            }
      
            return View(list);


        }
    }
}