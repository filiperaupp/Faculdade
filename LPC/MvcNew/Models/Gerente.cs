namespace MvcNew.Models
{
    public class Gerente : Pessoa
    {
       
        public double salario { get; set; }
        public Gerente(int id, string nome, double salario)
        {
            this.id = id;
            this.nome = nome;
            this.salario = salario;

        }
        
        public void aumentoSalarial(){
            this.salario = this.salario*1.1;
        }

        public void aumentoSalarial(double pctm){
            this.salario = this.salario*(pctm/100 + 1);
        }

    }
}