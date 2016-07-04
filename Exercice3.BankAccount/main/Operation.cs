namespace Exercice3.BankAccount.main
{
	public abstract class Operation
	{
		private readonly int _amount;

		public Operation(int amount)
		{
			_amount = amount;
		}

		public int Amount
		{
			get { return _amount; }
		}


		protected bool Equals(Operation other)
		{
			return _amount == other._amount;
		}

		public override int GetHashCode()
		{
			return _amount;
		}

		public abstract int Apply(int balance);
	}
}