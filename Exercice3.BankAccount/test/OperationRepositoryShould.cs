using Exercice3.BankAccount.main;
using NFluent;
using Xunit;

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

	}
}