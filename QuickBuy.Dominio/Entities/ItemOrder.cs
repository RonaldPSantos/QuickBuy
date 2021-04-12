using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class ItemOrder
    {
        public int Id { get; set; }
        public int ProducId { get; set; }
        public int Amout { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
