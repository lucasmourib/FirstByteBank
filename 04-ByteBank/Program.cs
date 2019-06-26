using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente primeiraContaCorrente = new ContaCorrente();
			primeiraContaCorrente.Titular = new Cliente();
			primeiraContaCorrente.Titular.Nome = "gabriela";
			primeiraContaCorrente.Titular.Cpf = "46256323823";
			primeiraContaCorrente.Depositar(200.00);

			Console.WriteLine(primeiraContaCorrente.Titular.Nome);
			Console.WriteLine(primeiraContaCorrente.Saldo);
			Console.WriteLine(primeiraContaCorrente.Titular.Cpf);

			Console.ReadLine();
		}
	}
}
