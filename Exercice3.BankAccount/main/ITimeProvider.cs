using System;

namespace Exercice3.BankAccount.main
{
	public interface ITimeProvider
	{
		DateTime Now { get; }
	}
}