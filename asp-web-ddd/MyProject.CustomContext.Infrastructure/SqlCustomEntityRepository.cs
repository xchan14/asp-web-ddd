using MyProject.CustomContext.Domain;
using MyProject.CustomContext.Domain.AnotherAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CustomContext.Infrastructure
{
    /// <summary>
    /// An implementation of MyProject.CustomContext.Domain.AnotherEntityRepository.
    /// </summary>
    class SqlAnotherEntityRepository : AnotherEntityRepository
    {
        public void Create(AnotherEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AnotherEntity entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<AnotherEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public AnotherEntity GetById(AnotherEntityId id)
        {
            throw new NotImplementedException();
        }

        public void Update(AnotherEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
