namespace EstudoMVC.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string description { get; set; }
        public int qtd { get; set; }

        public int CategoriaID { get; set; }
        public Categoria categoria { get; set; }
    }
}