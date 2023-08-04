using System;

namespace modelo.Application.Models.PagamentoModel
{
    public class PagamentoPutRequest
    {
        public Guid Id { get; set; }
        public short Status { get; set; }
    }
}