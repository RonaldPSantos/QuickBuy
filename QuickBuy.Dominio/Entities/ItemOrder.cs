using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class ItemOrder : Entity
    {
        public int Id { get; set; }
        public int ProducId { get; set; }
        public int Amout { get; set; }

        public ICollection<Order> Orders { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
