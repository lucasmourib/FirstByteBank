using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
	class Program
	{
		static void Main(string[] args)
		{
			ContaCorrente primeiraContaCorrente = new ContaCorrente();
			primeiraContaCorrente.titular = new Cliente();
			primeiraContaCorrente.titular.nome = "gabriela";
			primeiraContaCorrente.Depositar(200.00);

			Console.WriteLine(primeiraContaCorrente.titular.nome);

			Console.ReadLine();
		}
	}
}
