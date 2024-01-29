using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Dtos.Book
{
    public record InsertBookDto
    {
        [Required(ErrorMessage = "Title is Required")]
        public string Title { get; init; }
        [Required(ErrorMessage = "CategoryId is Required")]
        public int CategoryId { get; init; }
        public decimal Price { get; init; }
    }
}
