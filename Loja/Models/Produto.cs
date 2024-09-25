namespace Loja.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }

        public int CategoriaId { get; set;}
        public Categoria? Categoria { get; set; }
    }
}
