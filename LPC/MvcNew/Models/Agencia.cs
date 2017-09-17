namespace MvcNew.Models
{
    public class Agencia
    {
        public Agencia(int id, long numero)
        {
            this.id = id;
            this.numero = numero;

        }
        public int id { get; set; }
        public long numero { get; set; }


    }
}