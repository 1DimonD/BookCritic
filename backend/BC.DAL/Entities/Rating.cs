using BC.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BC.DAL.Entities
{
    public class Rating : BaseEntity
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public byte Score { get; set; }
    }
}
