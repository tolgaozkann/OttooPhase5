using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Dtos.Category
{
    public record CategoryDto
    {
        public int Id { get; init; }
        public string? CategoryName { get; init; }
    }
}
