using Exercice3.BankAccount.main;
using Exercice3.BankAccountKata;
using FakeItEasy;
using Xunit;

namespace Exercice3.BankAccount.test
{
	public class BankAccountShould
	{
		private readonly Operation WITHDRAW_100_OPERATION = new WithdrawOperation(100);
		private readonly DepositOperation DEPOSIT_100_OPERATION = new DepositOperation(100);

		private readonly IOperationRepository _repository;
		private readonly main.BankAccount _account;
		private readonly IPrintService _printService;

		public BankAccountShould()
		{
			_repository = A.Fake<IOperationRepository>();
			_printService = A.Fake<IPrintService>();
			_account = new main.BankAccount(_repository, _printService);
		}

		[Fact]
		public void store_deposit_transaction_in_the_repository_when_deposit()
		{
			_account.Deposit(100);

			A.CallTo(() => _repository.Store(DEPOSIT_100_OPERATION)).MustHaveHappened(Repeated.Exactly.Once);
		}

		[Fact]
		public void store_withdraw_transaction_in_the_repository_when_withdraw()
		{
			_account.Withdraw(100);

			A.CallTo(() => _repository.Store(WITHDRAW_100_OPERATION)).MustHaveHappened(Repeated.Exactly.Once);			
		}

		[Fact]
		public void print_the_repository_statement()
		{
			var buildStatement = new Statement();
			A.CallTo(() => _repository.BuildStatement()).Returns(buildStatement);

			_account.PrintStatement();

			A.CallTo(() => _printService.Print(buildStatement)).MustHaveHappened(Repeated.Exactly.Once);
		}


	}
}