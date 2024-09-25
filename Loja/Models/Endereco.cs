namespace Loja.Models
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string? logradouro { get; set; }

        public string? Numero {  get; set; }

        public string? Cep { get; set; }

        public int ClienteID { get; set; }
        public Cliente? Cliente { get; set; }

    }
}
