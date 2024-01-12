using System.ComponentModel.DataAnnotations;

namespace TailwindTemplate.Application.Auth.DTOs;

public class LoginPostDTO
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public IEnumerable<AuthSchemeDTO> ExternalLogins { get; set; } = new List<AuthSchemeDTO>();

}
