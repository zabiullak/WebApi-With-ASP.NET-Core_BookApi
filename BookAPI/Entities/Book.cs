using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Entities
{
    public record Book
    {
        [Required]
        [Range(0, 100)]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Author { get; set; }

        [Range(1,1000)]
        public int Prize { get; set; }

        public DateTimeOffset Date { get; set; }

        public string Discription { get; set; }

    }
}
