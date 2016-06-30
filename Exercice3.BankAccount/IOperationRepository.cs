namespace Exercice3.BankAccountKata
{
	public interface IOperationRepository
	{
		void Store(Operation debitOperation);
		Statement BuildStatement();
	}
}