namespace modelo.Application.Models.PedidoModel
{
    public class GetItemPedidoUseCaseAsync
    {
        public string NomeProduto { get; set; }
        public string NomeCategoria { get; set; }
        public decimal Valor { get; set; }
        public string Observacao { get; set; }
    }
}