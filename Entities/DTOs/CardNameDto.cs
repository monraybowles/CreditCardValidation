using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.DTOs
{
    public class CardNameDto
    {
        [Key]
        public Guid TypeID { get; set; }
        public string CardType { get; set; }
    }
}
