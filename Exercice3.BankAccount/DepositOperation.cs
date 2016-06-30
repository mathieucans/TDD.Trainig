namespace Exercice3.BankAccountKata
{
	public class DepositOperation : Operation
	{
		public DepositOperation(int amount) : base(amount)
		{
		}

		public override bool Equals(object obj)
		{
			if (obj is DepositOperation)
			{
				return base.Equals((Operation)obj);
			}
			return base.Equals(obj);
		}
	}
}