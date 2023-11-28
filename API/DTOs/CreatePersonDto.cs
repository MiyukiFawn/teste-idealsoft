using System.ComponentModel.DataAnnotations;

namespace API.DTOs;
public class CreatePersonDto {
    [Required]
    [StringLength(15)]
    [MinLength(3, ErrorMessage = "The field 'Name' must contain at least 3 characters")]
    public string Name { get; set; }

    [Required]
    [StringLength(15)]
    [MinLength(3, ErrorMessage = "The field 'Surname' must contain at least 3 characters")]
    public string Surname { get; set; }

    [Required]
    [StringLength(9, ErrorMessage = "The field 'Phone' must contain 9 characters")]
    [MinLength(9, ErrorMessage = "The field 'Phone' must contain 9 characters")]
    [RegularExpression(@"^[0-9]*$")]
    public string Phone { get; set; }
}
