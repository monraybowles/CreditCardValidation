using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CardNameManager : ICardNameService
    {
        ICardNameDal _CardNameDal;
        public CardNameManager(ICardNameDal CardNameDal)
        {
            _CardNameDal = CardNameDal;
        }

        //[SecuredOperation("CreditCardValidation.add")]
        ////[ValidationAspect(typeof(CreditCardValidationValidator))]
        //[CacheRemoveAspect("ICreditCardValidationService.Add")]


        public IResult Add(CardName CardName)
        {
            //if (CreditCardValidation.FirstName.Length < 2 || CreditCardValidation.LastName.Length < 2)
            //    return new ErrorResult(Messages.UserNameInvalid);


            _CardNameDal.Add(CardName);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CardName CardName)
        {
            _CardNameDal.Delete(CardName);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<CardName>> GetAll()
        {
            return new SuccessDataResult<List<CardName>>(_CardNameDal.GetAll());
        }

        public IDataResult<CardName> GetById(Guid id)
        {
            return new SuccessDataResult<CardName>(_CardNameDal.Get(p => p.TypeID == id));
        }

        //public IDataResult<CardName> GetCardNameByCardNameId(Guid id)
        //{
        //    return new SuccessDataResult<CardName>(_CardNameDal.Get(p => p.Id == id));
        //}

        public IDataResult<List<CardName>> GetCardNameDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(CardName CardName)
        {
            throw new NotImplementedException();
        }
    }
}
