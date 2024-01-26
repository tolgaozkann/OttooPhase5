using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Dtos.Category
{
    public record InsertCategoryDto
    {
        [Required(ErrorMessage = "CategoryName is required")]
        [MaxLength(40)]
        [MinLength(3)]
        public string? CategoryName { get; set; }

    }
}
