using System;
using System.Collections.Generic;
using Exercice3.BankAccount.main;

namespace Exercice3.BankAccount.main
{

	public class OperationRepository : IOperationRepository
	{
		private readonly ITimeProvider _timeProvider;
		private List<Operation> _operationList;

		public OperationRepository(ITimeProvider timeProvider)
		{
			_timeProvider = timeProvider;
			_operationList = new List<Operation>();
		}

		public void Store(Operation operation)
		{
			_operationList.Add(operation);
		}

		public Statement BuildStatement()
		{
			var balance = 0;
			var buildStatement = new Statement();
			foreach (var operation in _operationList)
			{
				balance = balance + operation.Amount;
				buildStatement.AddLine(
					_timeProvider.Now,
					operation.Amount,
					balance);
			}
			return buildStatement;
		}
	}
}