
namespace Exercice3.BankAccount.main
{
	public class BankAccount
	{
		private readonly IOperationRepository _repository;
		private readonly IPrintService _printService;

		public BankAccount(IOperationRepository repository, IPrintService printService)
		{
			_repository = repository;
			_printService = printService;
		}

		public void Deposit(int amount)
		{	
			_repository.Store(new DepositOperation(amount));
		}

		public void Withdraw(int amount)
		{			
			_repository.Store(new WithdrawOperation(amount));
		}

		public void PrintStatement()
		{
			_printService.Print(_repository.BuildStatement());
		}
	}
}