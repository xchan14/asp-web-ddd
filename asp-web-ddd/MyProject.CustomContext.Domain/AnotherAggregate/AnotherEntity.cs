using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MyProject.CustomContext.Domain.AnotherAggregate
{
    public class AnotherEntity
    {

        public AnotherEntity(AnotherValueObject valueObject)
        {
            AnotherValueObject = valueObject;
        }

        public AnotherValueObject AnotherValueObject { get; private set; }

        public void SomeLogic()
        {
            // write some business logic here...
        }
    }
}
