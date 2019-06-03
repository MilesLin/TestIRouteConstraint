using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using TestIRouteConstraint.Models;
using TestIRouteConstraint.Services;

namespace TestIRouteConstraint.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new ProductContext())
            {
                db.Product.Add(new Product
                {
                    Name = Guid.NewGuid().ToString()
                });

                db.SaveChanges();
            }
            return View();
        }

        [ChildActionOnly]
        public ActionResult TestChild()
        {
            var svc = new NavService();

            // 這個方法可行
            var k = Task.Run(async () => 
            {
                return await svc.TestChild();
            }).Result;

            // 這方法不可行
            //svc.TestChild().Result;

            return View("_child");
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
    }
}