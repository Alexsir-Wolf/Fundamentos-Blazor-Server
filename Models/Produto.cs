using FundamentosBlazorServer.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundamentosBlazorServer.Models;

public class Produto : BaseEntity<int>
{
    public Produto()
    {            
    }

	public Produto(
		int id, 
		string nome, 
		decimal preco, 
		int categoriaId)
	{
		Id = id;
		Nome = nome;
		Preco = preco;
		CategoriaId = categoriaId;
	}


    [Required(ErrorMessage = "Id é obrigatório")]
    public override int Id { get; set; }

    [Required(ErrorMessage = "Nome é obrigatório")]
    [MaxLength(50, ErrorMessage = "Nome deve conter no máximo de 50 caracteres")]
    [MinLength(5, ErrorMessage = "Nome deve conter no minimo de 5 caracteres")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "Preco é obrigatório")]
	[DataType(DataType.Currency)]
    [Range(1, 99999, ErrorMessage = "o Preço deve estar entre 1 e 99999")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "Categoria é obrigatório")]
    public int CategoriaId { get; set; }

    [ForeignKey("CategoriaId")]
    public Categoria? Categoria { get; set; }
}
