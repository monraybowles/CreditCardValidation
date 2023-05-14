using Core.DataAccess.Abstract;
using Core.Entities.Concrete;


namespace DataAccess.Abstract
{
    public interface ICardNameDal : IEntityRepository<CardName>
    {
        List<CardName> GetCardNameDetails();

        List<CardName> GetAll();
        List<CardName> GetCardNameByUserCardNameId(Guid id);
    }
}

