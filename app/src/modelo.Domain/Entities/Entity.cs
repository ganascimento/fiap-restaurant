using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Domain.Entities
{
    public abstract class Entity<Tkey>
    {
        public Tkey Id { get; set; }
    }
}
