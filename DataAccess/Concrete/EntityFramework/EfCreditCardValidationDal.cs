using Core.DataAccess.Concrete;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCreditCardValidationDal : EfEntityRepositoryBase<CreditCardValidation, ApplicationDbContext>, ICardValidationDal
    {
        public List<CreditCardValidation> GetAll()
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from CreditCardValidation in context.Card
                             //where CreditCardValidation.Id == user.Id
                             select new CreditCardValidation { CreditCardID = CreditCardValidation.CreditCardID, ModifiedDate= CreditCardValidation.ModifiedDate };

                return result.ToList();

            }
        }

        public List<CreditCardValidation> GetCreditCardValidation(CreditCardValidation user)
        {
            using (var context = new ApplicationDbContext())
            {
                var result = from CreditCardValidation in context.Card
                             where CreditCardValidation.CreditCardID== user.CreditCardID
                             select new CreditCardValidation { CreditCardID = CreditCardValidation.CreditCardID, ModifiedDate = CreditCardValidation.ModifiedDate };

                return result.ToList();

            }
        }

        public List<CreditCardValidation> GetCreditCardValidationByCreditCardValidationId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<CreditCardValidation> GetCreditCardValidationD()
        {
            throw new NotImplementedException();
        }

        public List<CreditCardValidation> GetCreditCardValidationDetails()
        {
            throw new NotImplementedException();
        }
    }
}
