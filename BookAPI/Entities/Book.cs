using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Entities
{
    public record Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Prize { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Discription { get; set; }
    }
}
