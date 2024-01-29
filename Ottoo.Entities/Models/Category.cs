using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }

        //navigation property
        public ICollection<Book> Books { get; set; }
    }
}
