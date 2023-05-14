using Core.Entities.Concrete;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface ICardNameService
    {


        IDataResult<List<CardName>> GetAll();
        IDataResult<List<CardName>> GetCardNameDetails();
        // IDataResult<List<CardName>> GetCardNameByCardNameId(Guid id);      
        IDataResult<CardName> GetById(Guid id);
        IResult Add(CardName CardName);
        IResult Delete(CardName CardName);
        IResult Update(CardName CardName);


    }
}