using ItSays.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Core.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
