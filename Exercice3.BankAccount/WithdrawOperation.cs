namespace Exercice3.BankAccountKata
{
	internal class WithdrawOperation : Operation
	{
		public WithdrawOperation(int amount) : base(amount)
		{			
		}

		public override bool Equals(object obj)
		{
			if (obj is WithdrawOperation)
			{
				return base.Equals((Operation) obj);
			}
			return base.Equals(obj);
		}
	}
}