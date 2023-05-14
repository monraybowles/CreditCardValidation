namespace Core.Entities.Concrete
{
    public class CreditCardValidation : IEntity
    {
        public Guid CreditCardID { get; set; }
        public string CardType { get; set; }        
        public string CardNumber { get; set; }
        public string CardHolder { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int CVV { get; set; }
        public DateTime ModifiedDate { get; set; }



    }
}
