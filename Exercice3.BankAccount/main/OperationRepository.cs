using System;

namespace Exercice3.BankAccount.main
{
	public class OperationRepository : IOperationRepository
	{
		public void Store(Operation debitOperation)
		{
			throw new NotImplementedException();
		}

		public Statement BuildStatement()
		{
			return new Statement();
		}
	}
}