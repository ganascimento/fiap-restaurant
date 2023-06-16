using System;

namespace modelo.Domain.Entities.Base
{
    public abstract class Entity<Tkey>
    {
        public Tkey Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
