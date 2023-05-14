using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCardNameDal : EfEntityRepositoryBase<CardName, ApplicationDbContext>,ICardNameDal
    {
               
        public List<CardName> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from CardName in context.CardName
                                 //where CardName.Id == user.Id
                             select new CardName { TypeID = CardName.TypeID, CardType = CardName.CardType };
                return result.ToList();
            }
        }

        public List<CardName> GetCardName(CardName user)
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from CardName in context.CardName
                             where CardName.TypeID== user.TypeID
                             select new CardName { TypeID = CardName.TypeID, CardType = CardName.CardType };

                return result.ToList();

            }
        }

        public List<CardName> GetCardNameByCardNameId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<CardName> GetCardNameByUserCardNameId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<CardName> GetCardNameDetails()
        {
            throw new NotImplementedException();
        }
        // this handles the Tax Details
        public List<CardName> GetCreditCardValidationDetails()
        {
            throw new NotImplementedException();
        }

    
    }
}
