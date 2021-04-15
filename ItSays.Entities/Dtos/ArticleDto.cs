using ItSays.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItSays.Entities.Dtos
{
    public class ArticleDto : IDto
    {
        public int Number { get; set; }
        public int CategoryNumber { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Writing { get; set; }
        public DateTime Date { get; set; }
        public string CategoryName { get; set; }
    }
}
