using QuickBuy.Dominio.ObjectValue;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Dominio.Entities
{
    public class Order : Entity
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
        public int PaymentMethodId { get; set; }

        public PaymentMethod paymentMethod { get; set; }

        public ICollection<ItemOrder> ItemsOrder { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrEmpty(PostalCode))
                AddReview("Informe um CEP");

            if (!ItemsOrder.Any())
                AddReview("O pedido não pode ficar sem itens.");

            if (String.IsNullOrEmpty(PostalCode))
                AddReview("Informe um CEP");

            if (String.IsNullOrEmpty(State))
                AddReview("Informe o Estado");

            if (String.IsNullOrEmpty(City))
                AddReview("Informe a Cidade");

            if (String.IsNullOrEmpty(Adress))
                AddReview("Informe o endereço");

            if (PaymentMethodId == 0)
                AddReview("Informe a forma de pagamento");
        }
    }
}
