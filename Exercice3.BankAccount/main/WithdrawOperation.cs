namespace Exercice3.BankAccount.main
{
	public class WithdrawOperation : Operation
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

		public override int Apply(int balance)
		{
			return balance - Amount;
		}

		public override void Accept(SignedAmountOperationVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}