using System;
using Exercice3.BankAccount.main;
using NFluent;
using Xunit;
using System.Linq;

namespace Exercice3.BankAccount.test
{
	public class OperationRepositoryShould
	{
		private OperationRepository _operationRepository;

		public OperationRepositoryShould()
		{
			_operationRepository = new OperationRepository();
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
			_operationRepository.Store(new DepositOperation(100));

			var statement = _operationRepository.BuildStatement();

			Check.That(statement.Lines.First().Date).Equals(DateTime.Parse("30/06/2016 15:56"));
		}

	}
}