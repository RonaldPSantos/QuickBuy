using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using QuickBuy.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repository.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
