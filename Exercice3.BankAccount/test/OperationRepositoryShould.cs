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
		public void build_a_statement_with_the_current_date_and_the_balance_equals_to_the_amount_when_first_deposit()
		{
			var now = DateTime.Parse("30/06/2016 15:56");
			A.CallTo(() => _timeProvider.Now).Returns(now);
			_operationRepository.Store(new DepositOperation(100));

			var statement = _operationRepository.BuildStatement();


			Check.That(statement.Lines.First().Date).Equals(now);
			Check.That(statement.Lines.First().Amount).IsEqualTo(100);
			Check.That(statement.Lines.First().Balance).IsEqualTo(100);
		}
	}
}

	