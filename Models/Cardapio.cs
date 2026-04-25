namespace NicosCardapio.Api.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Icone { get; set; } = string.Empty;
        public List<Item> Itens { get; set; } = new();
    }

    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public decimal Preco { get; set; }
        public string? SubCategoria { get; set; }
        public bool Destaque { get; set; } = false;
    }
}
