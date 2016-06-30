namespace Exercice3.BankAccount.main
{
	public abstract class Operation
	{
		private int _amount;

		public Operation(int amount)
		{
			_amount = amount;
		}

		protected bool Equals(Operation other)
		{
			return _amount == other._amount;
		}

		public override int GetHashCode()
		{
			return _amount;
		}
	}
}