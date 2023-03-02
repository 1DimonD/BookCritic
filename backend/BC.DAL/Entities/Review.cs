using BC.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DAL.Entities
{
    public class Review : BaseEntity
    {
        public string Message { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public string Reviewer { get; set; } 
    }
}
