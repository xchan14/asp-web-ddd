using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.CustomContext.Domain.AnotherAggregate
{
    public class AnotherEntityId
    {
        public AnotherEntityId(int someId)
        {
            Id = someId;
        }

        public int Id { get; private set; }
    }
}
