namespace Loja.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime DataCompra { get; set; }

        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
    }
}
