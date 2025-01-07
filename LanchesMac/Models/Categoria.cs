namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get;}
        public string Descricao { get;}

        // Lista Lanches
        public List<Lanche> Lanches { get;}
    }
}
