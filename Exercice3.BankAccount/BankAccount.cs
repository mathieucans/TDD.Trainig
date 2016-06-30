namespace Exercice3.BankAccountKata
{
	public class BankAccount
	{
		private readonly IOperationRepository _repository;

		public BankAccount(IOperationRepository repository)
		{
			_repository = repository;
		}

		public void Deposit(int amount)
		{	
			_repository.Store(new DepositOperation(amount));
		}

		public void Withdraw(int amount)
		{			
		}

		public void PrintStatement()
		{			
		}
	}
}