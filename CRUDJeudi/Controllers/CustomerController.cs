using CRUDJeudi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDJeudi.Controllers
{
    public class CustomerController : Controller
    {

        ShopEntities db = new ShopEntities();

        // GET: Customer
        public ActionResult CustomerList()
        {
            var customers = db.customers.ToList();
            return View(customers);
        }
    }
}