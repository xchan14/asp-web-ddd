using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CustomContext.Domain.AnotherAggregate
{
    public class AnotherValueObject
    {
        public AnotherValueObject(int someProperty)
        {
            SomeProperty = someProperty;
        }

        public int SomeProperty { get; private set; }
    }
}
