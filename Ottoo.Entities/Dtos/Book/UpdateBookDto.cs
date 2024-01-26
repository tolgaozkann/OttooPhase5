using System.ComponentModel.DataAnnotations;

namespace Ottoo.Entities.Dtos.Book
{
    public record UpdateBookDto 
    {
        [Required]
        public int Id { get; init; }
        [Required(ErrorMessage = "This must be filled")]
        [MinLength(3, ErrorMessage = "This field must have at least 3 characters")]
        [MaxLength(50, ErrorMessage = "This field must have at most 50 characters")]
        public string Title { get; init; }

        [Required(ErrorMessage = "This must be filled")]
        [Range(10, 1000)]
        public decimal Price { get; init; }
    }
}
