using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.DTOs
{
    public class CreditCardValidationDto : IDto
    {


        [Key]
        public Guid CreditCardID { get; set; }


        [Display(Name = "Card Type")]
        [Required(ErrorMessage = "Card Type is Required!")]
        public string CardType { get; set; }

        [Display(Name = "Card Number")]
        [Required(ErrorMessage = "Card Number is Required!")]
        public string CardNumber { get; set; }


        [Display(Name = "Card Holder")]
        [Required(ErrorMessage = "Card Holder name is Required!")]
        public string CardHolder { get; set; }



        [Display(Name = "Exp Month")]
        [Required(ErrorMessage = "Exp Month is Required!")]  
        public int ExpMonth { get; set; }


        [Display(Name = "Exp Year")]
        [Required(ErrorMessage = "Exp Year Required!")]
        public int ExpYear { get; set; }


        [Display(Name = "CVV")]
        [Required(ErrorMessage = "CVV Required!")]
        public int CVV { get; set; }

        [Display(Name = "Modified Date")]
        public DateTime ModifiedDate { get; set; }






    }
}
