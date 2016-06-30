using FakeItEasy;
using NFluent;
using Xunit;

namespace Exercice3.BankAccountKata
{
	public class BankAccountShould
	{
		private DepositOperation DEBIT_OPERATION = new DepositOperation(100);

		[Fact]
		public void store_deposit_transaction_in_the_repository_when_deposit()
		{
			var repository = A.Fake<IOperationRepository>();
			var bankAccount = new BankAccount();

			bankAccount.Deposit(100);

			A.CallTo(() => repository.Store(DEBIT_OPERATION)).MustHaveHappened(Repeated.Exactly.Once);
		}

	}

	public class DepositOperation
	{
		public DepositOperation(int amount)
		{			
		}
	}

	public interface IOperationRepository
	{
		void Store(DepositOperation debitOperation);
	}
}