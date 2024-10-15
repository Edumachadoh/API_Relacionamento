namespace API.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string? Nome { get; set; }
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        // Relacionamento com Produtos
        public ICollection<Produto>? Produtos { get; set; } // Propriedade de navegação
    }
}
