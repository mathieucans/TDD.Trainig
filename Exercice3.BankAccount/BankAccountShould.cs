using FakeItEasy;
using NFluent;
using Xunit;

namespace Exercice3.BankAccountKata
{
	public class BankAccountShould
	{
		private readonly DepositOperation DEPOSIT_100_OPERATION = new DepositOperation(100);
		
		private readonly IOperationRepository _repository;
		private BankAccount _account;
		private Operation WITHDRAW_100_OPERATION = new WithdrawOperation(100);

		public BankAccountShould()
		{
			_repository = A.Fake<IOperationRepository>();
			_account = new BankAccount(_repository);
		}

		[Fact]
		public void store_deposit_transaction_in_the_repository_when_deposit()
		{
			Check.That(DEPOSIT_100_OPERATION).Equals(new DepositOperation(100));
			_account.Deposit(100);

			A.CallTo(() => _repository.Store(DEPOSIT_100_OPERATION)).MustHaveHappened(Repeated.Exactly.Once);
		}

		[Fact]
		public void store_withdraw_transaction_in_the_repository_when_withdraw()
		{
			_account.Withdraw(100);

			A.CallTo(() => _repository.Store(WITHDRAW_100_OPERATION)).MustHaveHappened(Repeated.Exactly.Once);			
		}


	}

	public interface IOperationRepository
	{
		void Store(Operation debitOperation);
	}
}