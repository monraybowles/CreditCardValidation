using Core.Entities.Concrete;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface ICardService
    {


        IDataResult<List<CreditCardValidation>> GetAll();
        IDataResult<List<CreditCardValidation>> GetCreditCardValidationDetails();
       // IDataResult<List<CreditCardValidation>> GetCreditCardValidationByCreditCardValidationId(Guid id);      
        IDataResult<CreditCardValidation> GetById(Guid id);
        IResult Add(CreditCardValidation CreditCardValidation);
        IResult Delete(CreditCardValidation CreditCardValidation);
        IResult Update(CreditCardValidation CreditCardValidation);


    }
}
