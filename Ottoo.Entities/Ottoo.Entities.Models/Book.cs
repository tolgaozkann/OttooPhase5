using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Ottoo.Entities.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        //navigation property
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
