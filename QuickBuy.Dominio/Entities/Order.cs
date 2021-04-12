using QuickBuy.Dominio.ObjectValue;
using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateOrder { get; set; }
        public int UserId { get; set; }
        public DateTime DeliveryForecast { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public int Number { get; set; }
        public int PaymentMEthodId { get; set; }

        public PaymentMethod paymentMethod { get; set; }

        public ICollection<ItemOrder> ItemsOrder { get; set; }
    }
}
