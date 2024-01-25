using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Ottoo.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }

        //navigation property
        public ICollection<Book> Books { get; set; }
    }
}
