using System;
using DIO.Bank.Enum;
using System.Text;





namespace DIO.Bank.Classes
{
    public class Conta
    {
        private TipoConta TipoConta {get;set;}
        private double Saldo {get;set;}
        private double Credito {get;set;}
        private string Nome {get;set;}








        public Conta (TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
        }








        public bool Sacar(double valorSaque)
        {
            if( (this.Saldo - valorSaque) < (this.Credito * -1) )
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }


            this.Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this. Saldo);


            return true;
        }
        





        public void Depositar(double valorDeposito)
        {
            this.Saldo += valorDeposito;

            Console.WriteLine("O Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
        }







        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if(this.Sacar(valorTransferencia))
                contaDestino.Depositar(valorTransferencia);
        }





        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append("Tipo Conta" + this.TipoConta + " | ");
            retorno.Append("Nome " + this.Nome + " | ");
            retorno.Append("Saldo " + this.Saldo + " | ");
            retorno.Append("Crédito " + this.Credito);

            return retorno.ToString();
        }




    }
}