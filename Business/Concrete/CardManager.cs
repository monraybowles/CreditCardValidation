using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CardValidationManager : ICardService
    {
        ICardValidationDal _CreditCardValidationDal;
        public CardValidationManager(ICardValidationDal CreditCardValidationDal)
        {
            _CreditCardValidationDal = CreditCardValidationDal;
        }

        //[SecuredOperation("CreditCardValidation.add")]
        ////[ValidationAspect(typeof(CreditCardValidationValidator))]
        //[CacheRemoveAspect("ICreditCardValidationService.Add")]
      

        public IResult Add(CreditCardValidation CreditCardValidation)
        {
          
            //    return new ErrorResult(Messages.UserNameInvalid);


            _CreditCardValidationDal.Add(CreditCardValidation);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CreditCardValidation CreditCardValidation)
        {
            _CreditCardValidationDal.Delete(CreditCardValidation);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<CreditCardValidation>> GetAll()
        {
            return new SuccessDataResult<List<CreditCardValidation>>(_CreditCardValidationDal.GetAll());
        }

        public IDataResult<CreditCardValidation> GetById(Guid id)
        {
            return new SuccessDataResult<CreditCardValidation>(_CreditCardValidationDal.Get(p => p.CreditCardID == id));
        }

        //public IDataResult<CreditCardValidation> GetCreditCardValidationByCreditCardValidationId(Guid id)
        //{
        //    return new SuccessDataResult<CreditCardValidation>(_CreditCardValidationDal.Get(p => p.Id == id));
        //}

        public IDataResult<List<CreditCardValidation>> GetCreditCardValidationDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(CreditCardValidation CreditCardValidation)
        {
            throw new NotImplementedException();
        }
    }
}
