namespace QuickBuy.Dominio.Entities
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                AddReview("Informe um nome para p Produto");

            if (string.IsNullOrEmpty(Description))
                AddReview("Insira uma descrição do produto");

            if (Price == 0)
                AddReview("Informe um preço para o produto");
        }
    }
}
