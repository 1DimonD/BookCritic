using BC.DAL.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DAL.Entities
{
    public class Book : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Cover { get; set; }
        public string Content { get; set; }
        [Required]
        public string Author { get; set; }
        public string Genre { get; set; }

        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
