using modelo.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo.Domain.Enums;

namespace modelo.Domain.Entities
{
    public class Acompanhamento : Entity<Guid>
    {
        public int Senha { get; set; }

        public int Status { get; set; }
    }
}
