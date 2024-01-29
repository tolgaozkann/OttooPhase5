using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Dtos.User
{
    public record UserDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "UserName is required.")]
        public string UserName { get; init; }
    }
}
