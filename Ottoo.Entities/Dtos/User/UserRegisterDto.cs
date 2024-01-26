using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ottoo.Entities.Dtos.User
{
    public record UserRegisterDto
    {
        [Required(ErrorMessage = "UserNamer is Required.")]
        public string UserName { get; set; }
    }
}
