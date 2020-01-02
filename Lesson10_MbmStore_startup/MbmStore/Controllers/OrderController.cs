using Microsoft.AspNetCore.Mvc;
using MbmStore.Models.ViewModels;
using MbmStore.Data;
using MbmStore.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;

namespace MbmStore.Controllers
{
    public class OrderController : Controller
    {
        private Cart cart;
        private readonly IInvoiceRepository invoiceRepo;


        public OrderController(Cart cartService, IInvoiceRepository invoiceRepo)
        {
            cart = cartService;
            this.invoiceRepo = invoiceRepo;
        }


        public ViewResult Checkout()
        {
            return View(new Order());
        }


        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            if (cart.Lines.Count == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            if (ModelState.IsValid)
            {
                invoiceRepo.SaveInvoice(cart, order);

                cart.Clear();
                return View("Completed");
            }
            else
            {
                return View(order);
            }
        }
    }
}