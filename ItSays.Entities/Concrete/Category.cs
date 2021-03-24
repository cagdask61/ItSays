using ItSays.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
