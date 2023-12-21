using FundamentosBlazorServer.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FundamentosBlazorServer.Models;

public class Categoria : BaseEntity<int>
{
    public Categoria()
    {            
    }

	public Categoria(
		int id, 
		string nome)
	{
		Id = id;
		Nome = nome;
	}

	[Key]
	[Required(ErrorMessage = "Id é obrigatório.")]
	public override int Id { get; set; }

	[Required(ErrorMessage = "Nome é obrigatório")]
	[MaxLength(50, ErrorMessage = "Nome deve conter no máximo de 50 caracteres")]
	[MinLength(5, ErrorMessage = "Nome deve conter no minimo de 5 caracteres")]
	public string Nome { get; set; } = string.Empty;

    [InverseProperty("Categoria")]
	public List<Produto>? Produtos { get; set; }
}
