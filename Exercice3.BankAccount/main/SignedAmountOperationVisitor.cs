namespace Exercice3.BankAccount.main
{
	public class SignedAmountOperationVisitor
	{
		public double SignedAmount { get; private set; }

		public void Visit(DepositOperation depositOperation)
		{
			SignedAmount = depositOperation.Amount;
		}

		public void Visit(WithdrawOperation depositOperation)
		{
			SignedAmount = -1*depositOperation.Amount;
		}
	}
}