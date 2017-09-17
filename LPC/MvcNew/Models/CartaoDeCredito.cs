using System;

namespace MvcNew.Models
{
    public class CartaoDeCredito
    {
        public int id { get; set; }
        public long numero { get; set; }
        public DateTime dataValidade { get; set; }
        public Cliente cliente { get; set; }
        

        public CartaoDeCredito (int id, int numero, DateTime dataValidade, Cliente cliente) {
            this.id = id;
            this.numero = numero;
            this.dataValidade = dataValidade;
            this.cliente = cliente;
        }
    }
}