using MbmStore.Models;
using MbmStore.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MbmStore.Data
{
    public class EFInvoiceRepository : IInvoiceRepository
    {
        private readonly MbmStoreContext dataContext;

        public EFInvoiceRepository(MbmStoreContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void SaveInvoice(Cart cart, Order order)
        {
            Customer customer = new Customer
            {
                Firstname = order.FirstName,
                Lastname = order.LastName,
                Address = order.Line1 + " " + order.Line2 + " " + order.Line3,
                Zip = order.Zip,
                Email = order.Email
            };
            if(dataContext.Customers.Any(c => c.Firstname == customer.Firstname &&
            customer.Lastname == customer.Lastname && customer.Email == customer.Email))
            {
                customer = dataContext.Customers.Where(c => c.Firstname == customer.Firstname &&
                c.Lastname == customer.Lastname && c.Email == customer.Email).First();
                customer.Address = order.Line1 + " " + order.Line2 + " " + order.Line3;
                customer.Zip = order.Zip;
                // ensure update instead of insert
                dataContext.Entry(customer).State = EntityState.Modified;
            }
            Invoice invoice = new Invoice { Customer = customer, OrderDate = DateTime.Now };
            foreach(CartLine cartLine in cart.Lines)
            {
                OrderItem orderItem = new OrderItem(cartLine.Product, cartLine.Quantity);
                // price when item went into the basket
                orderItem.ProductId = cartLine.Product.ProductId;
                orderItem.Price = cartLine.Price;
                orderItem.Product = null;
                invoice.OrderItems.Add(orderItem);
            }
            dataContext.Invoices.Add(invoice);
            dataContext.SaveChanges();
        }
    }
}
