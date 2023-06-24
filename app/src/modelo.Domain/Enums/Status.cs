using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Domain.Enums
{
    public sealed class Status
    {
        public static Status Pendente { get; } = new Status(0, "Pendente");
        public static Status EmPreparo { get; } = new Status(1, "Em Preparo");
        public static Status Pronto { get; } = new Status(2, "Pronto");
        public static Status Entregue { get; } = new Status(3, "Entregue");

        private Status(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }

        public static Status GetById(int id)
        {
            switch (id)
            {
                case 0:
                    return Pendente;
                case 1:
                    return EmPreparo;
                case 2:
                    return Pronto;
                case 3:
                    return Entregue;
                default:
                    throw new ArgumentOutOfRangeException(nameof(id), $"Invalid Status ID: {id}");
            }
        }
    }
}
