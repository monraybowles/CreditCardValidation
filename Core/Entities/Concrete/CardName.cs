using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Concrete
{
    public class CardName : IEntity
    {
        [Key]
        public Guid TypeID { get; set; }
        public string CardType { get; set; }
    }
}
