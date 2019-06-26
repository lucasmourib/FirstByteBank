namespace _04_ByteBank
{
	class ContaCorrente
	{
		public int Agencia { get; set; }
		public int Numero { get; set; }
		public double Saldo { get; set; }
		public Cliente Titular { get; set; }

		public void Depositar(double valor)
		{
			this.Saldo += valor;
		}

		public bool Sacar(double valor)
		{
			if (this.Saldo < valor)
			{
				return false;
			}
			this.Saldo -= valor;
			return true;
		}

		public bool Transferir(ContaCorrente contaDestino, double valor)
		{
			if (this.Saldo < valor)
			{
				return false;
			}
			this.Saldo -= valor;

			contaDestino.Depositar(valor);
			return true;
		}
	}
}
