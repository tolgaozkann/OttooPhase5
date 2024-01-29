using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Dtos.Book
{
    public record BookDto
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public int CategoryId { get; init; }
        public decimal Price { get; init; }
    }
}
