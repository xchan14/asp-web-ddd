using MyProject.CustomContext.Domain.AnotherAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CustomContext.Application
{
    public class AnotherService
    {
        private AnotherEntityRepository _anotherEntityRepository;

        public AnotherService(AnotherEntityRepository anotherEntityRepository)
        {
            _anotherEntityRepository = anotherEntityRepository;
        }

        public void CreateNewEntity(int x)
        {
            var valueObject = new AnotherValueObject(2);
            var entity = new AnotherEntityFactory().CreateWithValueObject(valueObject);
            _anotherEntityRepository.Create(entity);
        }

        public void SomeOperation(AnotherEntityId id)
        {
            AnotherEntity entity = _anotherEntityRepository.GetById(id);

            entity.SomeLogic();

            _anotherEntityRepository.Update(entity);
        }

    }
}
