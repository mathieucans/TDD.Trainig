using System;
using System.Collections.Generic;

namespace Exercice3.BankAccount.main
{
	public class OperationRepository : IOperationRepository
	{
		private List<Operation> _operationList;

		public OperationRepository()
		{
			_operationList = new List<Operation>();	
		}

		public void Store(Operation operation)
		{
		
		}

		public Statement BuildStatement()
		{
			return new Statement();
		}
	}
}