using projetoBancoExercício;
using System;
using System.Diagnostics;
using System.Globalization;


namespace bank
{
    class Agencia
    {
        static void Main(String[] args)
        {
            ContaBancaria usuario;
            Console.Write("Entre com o Número da conta:");
            int numConta = int.Parse(Console.ReadLine()); 
            Console.Write("Entre com o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito incial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S') {

                Console.Write("Entre com o valor que será depositado inicialmente: ");
                double depositoini = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                usuario = new ContaBancaria(numConta , titular ,depositoini);
            
            
            }
            else
            {
                usuario = new ContaBancaria(numConta, titular);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Dados da conta");
            Console.WriteLine(usuario);
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito:");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            usuario.Deposito(valor);
            Console.WriteLine("Dados atualizados");
            Console.WriteLine(usuario);

            Console.WriteLine();
            Console.WriteLine("Entre com o valor de saque (5 R$ de taxa): ");
            valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            usuario.Saque(valor);
            Console.WriteLine("Dados atualizados");
            Console.WriteLine(usuario);
        }

    }

}