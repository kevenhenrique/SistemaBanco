using System.Globalization;

namespace projetoBancoExercício
{
     class ContaBancaria
    {
        public int Numconta { get; private set; }
        public string Titular {  get; set; }
        public double Saldo{get; private set; }
        

        public ContaBancaria(int numconta, string titular)
        {
            Numconta = numconta;                
            Titular = titular; 
           
            

        }

        public ContaBancaria(int numconta, string titular, double saldo) : this (numconta, titular)
        {
            Saldo = saldo;

        }
        public void Deposito(double valor) {
                 Saldo += valor;
          
        }

       public void Saque(double valor)
        {
               Saldo -= valor + 5.0;
            
        }






        public override string ToString()
        {
            return "Numero da conta: "
          + Numconta
          +", "
          + "Titular: "
           + Titular
           +", "
           + "Saldo: "
            + Saldo.ToString("F2",CultureInfo.InvariantCulture);


        }
    }
}

