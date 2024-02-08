using System.ComponentModel.DataAnnotations;

namespace AppVendasWeb.Models
{
	public class Produto
	{
		public Guid ProdutoId { get; set; }

		[Required(ErrorMessage = "O campo descrição é obrigatório")]
		[Display(Name = "Nome do produto")]
		[StringLength(100, MinimumLength = 3, ErrorMessage = "O campo descrição deve ter entre 3 e 100 caracteres")]
		public string Descricao { get; set; }

		[Required(ErrorMessage = "O campo preço é obrigatório")]
		[Display(Name = "Preço")]
		public decimal Preco { get; set; }

		[Display(Name = "Categoria")]
		public Guid CategoriaId { get; set; }
		public Categoria? Categoria { get; set; }
	}
}
