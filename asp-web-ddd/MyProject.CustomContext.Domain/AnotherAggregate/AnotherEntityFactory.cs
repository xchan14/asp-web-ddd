using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CustomContext.Domain.AnotherAggregate
{
    public class AnotherEntityFactory
    {
        public AnotherEntity CreateWithValueObject(AnotherValueObject valueObject)
        {
            var entity = new AnotherEntity(valueObject);
            return entity;
        }
    }
}
