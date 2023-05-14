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

        private readonly ApplicationDbContext _context;
        private readonly ICardService _cardResolver;
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
            //-- loads the list and postal codes
            Cardlist = Cardlist = _context.Card.ToList();
        }

        public void OnPost()
        {
            // check form field and trigger validations
            if (!ModelState.IsValid)
            { 
               // ----------
                //return RedirectToPage();
            }
            else
            {
               
                _context.SaveChanges();
                //return RedirectToPage("./Index");
            }
        }


    }
}