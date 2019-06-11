using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente primeiraContaCorrente = new ContaCorrente();
			primeiraContaCorrente.Depositar(200.00);

			Console.WriteLine("Saldo da primeira conta corrente:" + primeiraContaCorrente.saldo);

			primeiraContaCorrente.Sacar(50.00);
			Console.WriteLine("Saldo da primeira conta corrente:" + primeiraContaCorrente.saldo);

			ContaCorrente segundaContaCorrente = new ContaCorrente();
			segundaContaCorrente.Depositar(50.00);			
			Console.WriteLine("Saldo da segunda conta corrente:" + segundaContaCorrente.saldo);

			primeiraContaCorrente.Transferir(segundaContaCorrente, 50.00);


			Console.WriteLine("Saldo da primeira conta corrente:" + primeiraContaCorrente.saldo);
			Console.WriteLine("Saldo da segunda conta corrente:" + segundaContaCorrente.saldo);


			Console.ReadLine();
		}
	}
}
