using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Domain.Entities
{
    public class Cliente: Entity<Guid>
    {
        public string Nome { get; set; }
        public string CPF { get; set; }

    }
}
