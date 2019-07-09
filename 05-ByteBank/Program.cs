using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

			ContaCorrente primeiraContaCorrente = new ContaCorrente(846, 8467951);

			primeiraContaCorrente.Titular = new Cliente();
			primeiraContaCorrente.Titular.Nome = "gabriela";
			primeiraContaCorrente.Titular.Cpf = "46256323823";
			primeiraContaCorrente.Depositar(200.00);

			Console.WriteLine(primeiraContaCorrente.Titular.Nome);
			Console.WriteLine(primeiraContaCorrente.Saldo);
			Console.WriteLine(primeiraContaCorrente.Numero);

			Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


			ContaCorrente segundaContaCorrente = new ContaCorrente(846, 8467951);

			segundaContaCorrente.Titular = new Cliente();
			segundaContaCorrente.Titular.Nome = "Lucas";

			Console.WriteLine(segundaContaCorrente.Titular.Nome);
			Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

			Console.ReadLine();
		}
	}
}
