using System.ComponentModel.DataAnnotations;

namespace Api_React_Fast_Food_Online.Server.DTOs.Account
{
    public class LoginDto
    {
        [Required(ErrorMessage = "UserName is required.")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Display(Name = "Remeber Me")]
        public bool RememBerMe { get; set; }
    }
}