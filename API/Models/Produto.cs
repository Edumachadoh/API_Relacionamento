namespace API.Models
{
    public class Produto
    {
        // Construtor da classe
        public Produto()
        {
            Id = Guid.NewGuid().ToString();
            CriadoEm = DateTime.Now;
        }

        // Atributos com get e set
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        // Relacionamento com Categoria (Chave Estrangeira)
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; } // Propriedade de navegação
    }
}
