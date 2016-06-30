namespace Exercice3.BankAccountKata
{
	public class DepositOperation
	{
		protected bool Equals(DepositOperation other)
		{
			return _amount == other._amount;
		}

		public override int GetHashCode()
		{
			return _amount;
		}

		private readonly int _amount;

		public DepositOperation(int amount)
		{
			_amount = amount;
		}

		public override bool Equals(object obj)
		{
			if (obj is DepositOperation)
			{
				return Equals((DepositOperation) obj);
			}
			return base.Equals(obj);
		}
	}
}