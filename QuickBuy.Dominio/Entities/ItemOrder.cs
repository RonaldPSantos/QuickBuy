using System.Collections.Generic;

namespace QuickBuy.Dominio.Entities
{
    public class ItemOrder : Entity
    {
        public int Id { get; set; }
        public int ProducId { get; set; }
        public int Amout { get; set; }

        public override void Validate()
        {
            if (ProducId == 0)
                AddReview("Não foi identificado qual a referência do produto");

            if (Amout == 0)
                AddReview("Quantidade não foi informado");
        }
    }
}
