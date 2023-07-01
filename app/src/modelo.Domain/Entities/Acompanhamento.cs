using modelo.Domain.Entities.Base;
using System;

namespace modelo.Domain.Entities
{
    public class Acompanhamento : Entity<Guid>
    {
        public int Senha { get; set; }

        public int Status { get; set; }
    }
}
