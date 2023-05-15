using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebClient.Pages
{
    public class IndexModel : PageModel
    {
        public readonly ApplicationDbContext _context;
        public readonly ICardService _cardResolver;
        public IndexModel(ApplicationDbContext context, ICardService cardResolver)
        {

            // Load Carn=d names data list
            _context = context;
            _cardResolver = cardResolver;
             CardName = context.CardName.Select(a =>
                                 new SelectListItem
                                 {
                                     Value = a.TypeID.ToString(),
                                     Text = a.CardType
                                 }).ToList();
        }
        public List<SelectListItem> CardName { get; set; }


        public IList<CreditCardValidationDto> Cardlist { get; set; }  
        [BindProperty]
        public CreditCardValidationDto Card { get; set; }
        public void OnGet()
        {
            //-- loads the list and CREDIT CARD TYPES
            Cardlist = Cardlist = _context.Card.ToList();
        }

        public RedirectToPageResult OnPost()
        {
            // check form field and trigger validations
            if (!ModelState.IsValid)
            { 
                // ----------
               return RedirectToPage();
            }
            else
            {
                Cardlist = Cardlist = _context.Card.ToList();

                //Check for duplicate entires before inserting data 

                if (Cardlist.Where(x => x.CardNumber == Card.CardNumber && x.CardHolder == Card.CardHolder).ToList().Count == 0)
                {                     

                    Card.CreditCardID = Guid.NewGuid();
                    Card.ModifiedDate = DateTime.Now;
                    _context.Card.Add(Card);
                    _context.SaveChanges();
                  
                }

               
            }
            return RedirectToPage("./Index");
        }
        private RedirectToPageResult PageResult()
        {
            return PageResult();
        }

    }
}