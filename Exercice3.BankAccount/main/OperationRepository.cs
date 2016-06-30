using System;

namespace Exercice3.BankAccount.main
{
	public class OperationRepository : IOperationRepository
	{
		public void Store(Operation debitOperation)
		{
			
		}

		public Statement BuildStatement()
		{
			return new Statement();
		}
	}
}