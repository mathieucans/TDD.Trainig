using Exercice3.BankAccountKata;

namespace Exercice3.BankAccount.main
{
	public interface IOperationRepository
	{
		void Store(Operation debitOperation);
		Statement BuildStatement();
	}
}