using MbmStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Data
{
    public interface IInvoiceRepository
    {
        void SaveInvoice(Cart cart, Order order);
    }
}
