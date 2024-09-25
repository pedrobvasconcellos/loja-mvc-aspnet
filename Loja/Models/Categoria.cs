namespace Loja.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Descritivo { get; set; }

        public ICollection<Produto>? Produtos { get; set; }
    }
}
