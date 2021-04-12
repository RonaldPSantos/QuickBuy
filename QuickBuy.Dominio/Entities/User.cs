namespace QuickBuy.Dominio.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AddReview("Informe um E-mail");

            if (string.IsNullOrEmpty(Password))
                AddReview("Informe uma senha");

        }
    }
}
