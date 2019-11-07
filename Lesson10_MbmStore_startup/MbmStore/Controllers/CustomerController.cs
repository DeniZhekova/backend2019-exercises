using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Data;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        private MbmStoreContext dataContext;

        public CustomerController(MbmStoreContext dbContext)
        {
            dataContext = dbContext;
        }
        // GET: Customers from DB
        public ActionResult Index()
        {
            return View(dataContext.Customers.ToList());
        }
    }
}