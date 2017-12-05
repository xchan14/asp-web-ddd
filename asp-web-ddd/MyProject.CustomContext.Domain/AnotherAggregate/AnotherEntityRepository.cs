using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CustomContext.Domain.AnotherAggregate
{
    public interface AnotherEntityRepository
    {
        ICollection<AnotherEntity> GetAll();
        AnotherEntity GetById(AnotherEntityId id);

        void Create(AnotherEntity entity);
        void Update(AnotherEntity entity);
        void Delete(AnotherEntity entity);
    }
}
