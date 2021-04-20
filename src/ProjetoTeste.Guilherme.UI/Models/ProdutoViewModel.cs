using System.ComponentModel.DataAnnotations;

namespace ProjetoTeste.Guilherme.UI.Models
{
    public class ProdutoViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Produto")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        [Display(Name = "Disponível?")]
        public bool Available { get; set; }
    }
}