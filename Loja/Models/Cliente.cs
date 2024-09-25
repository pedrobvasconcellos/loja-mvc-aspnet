using System.ComponentModel.DataAnnotations;

namespace Loja.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        [Required, MaxLength(80,ErrorMessage ="Nome não pode exceder 80 caracteres")]
        public string? Nome { get; set; }
        [Required,MaxLength(15)]
        public string? Cpf { get; set; }

        public Endereco? Endereco { get; set; }
    }
}
