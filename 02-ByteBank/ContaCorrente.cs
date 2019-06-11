using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
	class ContaCorrente
	{
		public string titular;
		public int agencia;
		public int numero;
		public double saldo;

		public void Depositar(double valor)
		{
			this.saldo = saldo + valor;
		}

		public bool Sacar(double valor)
		{
			if (this.saldo < valor)
			{
				return false;
			}
			this.saldo -= valor;
			return true;
		}

		public bool Transferir(ContaCorrente contaDestino, double valor)
		{
			if (this.saldo < valor)
			{
				return false;
			}
			this.saldo -= valor;

			contaDestino.Depositar(valor);
			return true;
		}
	}
}
