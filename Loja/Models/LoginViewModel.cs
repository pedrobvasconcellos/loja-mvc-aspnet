using System.ComponentModel.DataAnnotations;

namespace Loja.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="O E-mail é obrigatório")]
        [EmailAddress(ErrorMessage ="E-mail Inválido")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="A senha é obrigatória")]
        [DataType(DataType.Password)]
        public string? Password { get; set; } 
        
        [Display(Name = "Lembre-me")]
       
        public bool RememberMe { get; set; }
    }
}
