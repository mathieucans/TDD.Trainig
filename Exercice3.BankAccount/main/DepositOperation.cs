namespace Exercice3.BankAccount.main
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

		public override int Apply(int balance)
		{
			return balance + Amount; 
		}
	}
}