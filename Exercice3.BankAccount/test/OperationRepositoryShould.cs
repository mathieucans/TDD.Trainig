using System;
using Exercice3.BankAccount.main;
using NFluent;
using Xunit;
using System.Linq;
using FakeItEasy;

namespace Exercice3.BankAccount.test
{
	public class OperationRepositoryShould
	{
		private OperationRepository _operationRepository;
		private ITimeProvider _timeProvider;

		public OperationRepositoryShould()
		{
			_timeProvider = A.Fake<ITimeProvider>();
			_operationRepository = new OperationRepository(_timeProvider);
		}

		[Fact]
		public void build_an_empty_statement_when_no_operation_has_been_stored()
		{
			var statement = _operationRepository.BuildStatement();

			Check.That(statement.Lines.Count()).IsEqualTo(0);
		}
		
		[Fact]
		public void build_a_statment_with_an_increment_balance_for_each_deposit_operation()
		{
			var date1 = StoreAt(new DepositOperation(100), "29/06/2016 15:56");
			var date2 = StoreAt(new DepositOperation(100), "30/06/2016 15:56");

			var statement = _operationRepository.BuildStatement();

			Check.That(statement.Lines.ElementAt(0)).Equals(new StatementLine(date1, 100, 100));
			Check.That(statement.Lines.ElementAt(1)).Equals(new StatementLine(date2, 100, 200));
		}

		[Fact]
		public void build_a_statment_with_an_decrement_balance_for_each_withdraw_operation()
		{
			var date1 = StoreAt(new DepositOperation(1000), "29/06/2016 15:56");
			var date2 = StoreAt(new WithdrawOperation(100), "30/06/2016 15:56");

			var statement = _operationRepository.BuildStatement();

			Check.That(statement.Lines.ElementAt(0)).Equals(new StatementLine(date1, 1000, 1000));
			Check.That(statement.Lines.ElementAt(1)).Equals(new StatementLine(date2, 100, 900));
		}

		private DateTime StoreAt(Operation depositOperation, string date)
		{
			DateTime now = DateTime.Parse(date);
			A.CallTo(() => _timeProvider.Now).Returns(now);
			_operationRepository.Store(depositOperation);
			return now;
		}
	}
}

	