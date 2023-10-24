namespace InfobarAPI.Models
{
    public class PedidoInputModel
    {
        //Precisa terminar 
        public DateTime DataPedido { get; set; }
        public string NomeProduto { get; set; }
        public double Preco { get; set; }
        public List<int> ProdutosIds { get; set; }
    }
}
