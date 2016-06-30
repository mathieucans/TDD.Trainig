using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice3.BankAccount.main
{

	public class OperationRepository : IOperationRepository
	{
		private readonly ITimeProvider _timeProvider;
		private SortedDictionary<DateTime, Operation> _operationList;

		public OperationRepository(ITimeProvider timeProvider)
		{
			_timeProvider = timeProvider;
			_operationList = new SortedDictionary<DateTime, Operation>();
		}

		public void Store(Operation operation)
		{
			_operationList.Add(_timeProvider.Now, operation);
		}

		public Statement BuildStatement()
		{
			var balance = 0;
			var buildStatement = new Statement();

			foreach (var operation in _operationList)
			{
				balance = balance + operation.Value.Amount;
				buildStatement.AddLine(
					operation.Key,
					operation.Value.Amount,
					balance);
			}
			return buildStatement;
		}
	}
}