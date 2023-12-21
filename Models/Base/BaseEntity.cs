using FundamentosBlazorServer.Data;

namespace FundamentosBlazorServer.Models.Base;

public abstract class BaseEntity<TKey> : IEntity<TKey> where TKey : IEquatable<TKey>
{
    public BaseEntity()
    {
        DataCriacao = DateTime.Now;
    }

    public BaseEntity(TKey id)
    {
        Id = id;
    }

    public abstract TKey Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime? DataAlteracao { get; set; }
    public virtual bool Ativo { get; set; } = true;
}