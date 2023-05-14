using Core.DataAccess.Abstract;
using Core.Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface ICardValidationDal : IEntityRepository<CreditCardValidation>
    {
        List<CreditCardValidation> GetCreditCardValidationDetails();

        List<CreditCardValidation> GetCreditCardValidationD();
        List<CreditCardValidation> GetCreditCardValidationByCreditCardValidationId(Guid id);
    }}

