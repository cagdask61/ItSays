using ItSays.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Entities.Concrete
{
    public class Article : IEntity
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Writing { get; set; }
        public DateTime Date { get; set; }
    }
}
