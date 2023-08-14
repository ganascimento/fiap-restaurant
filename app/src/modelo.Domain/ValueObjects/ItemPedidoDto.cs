namespace modelo.Domain.ValueObjects
{
    public class ItemPedidoDto
    {
        public string NomeProduto { get; set; }
        public string NomeCategoria { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
    }
}