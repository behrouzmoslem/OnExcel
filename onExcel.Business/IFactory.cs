using System.Collections.Generic;

namespace onExcel.Business
{
    public interface IFactory<TEntity, Tdto>
        where TEntity : class
        where Tdto : class
    {
        TEntity CreateEntity(Tdto dto);
        Tdto CreateDto(TEntity entity);

        IEnumerable<TEntity> CreateEntity(IEnumerable<Tdto> dtos);

        IEnumerable<Tdto> CreateDto(IEnumerable<TEntity> entities);

    }
}