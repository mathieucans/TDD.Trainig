using Exercice3.BankAccount.main;
using NFluent;
using Xunit;

namespace Exercice3.BankAccount.test
{
	public class SignedAmountOperationVisitorShould
	{
		[Fact]
		public void convert_deposit_operation_with_positive_amount()
		{
			var visitor = new SignedAmountOperationVisitor();

			new DepositOperation(100).Accept(visitor);

			Check.That(visitor.SignedAmount).Equals(100.0);
		}

		[Fact]
		public void convert_withdraw_operation_with_negative_amount()
		{
			var visitor = new SignedAmountOperationVisitor();

			new WithdrawOperation(100).Accept(visitor);

			Check.That(visitor.SignedAmount).Equals(-100.0);
		}
	}


}