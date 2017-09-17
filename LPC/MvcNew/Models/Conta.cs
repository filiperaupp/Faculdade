using System;

namespace MvcNew.Models
{
    public class Conta
    {

        public Conta(int id, long numero, double saldo, Cliente cliente)
        {
            this.id = id;
            this.numero = numero;
            this.saldo = saldo;
            this.limite = 100;
            this.cliente = cliente;

        }
        public int id { get; set; }
        public long numero { get; set; }
        public double saldo { get; set; }
        public double limite { get; set; }
        public Cliente cliente { get; set; }

        public void depositar(double valor) {
            this.saldo += valor;
        }

        public bool sacar(double valor) {
            if (this.saldo<valor) {
                return false;
            }
            else {
                this.saldo -= valor;
                return true;
            }
        }
        public void mostrarSaldo() {
            Console.WriteLine("Saldo da conta: " + this.saldo);
        }
    }
}