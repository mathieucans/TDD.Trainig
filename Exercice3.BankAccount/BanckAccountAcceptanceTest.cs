using System;
using System.Collections.Generic;
using System.Text;
using Exercice3.BankAccount.main;
using Exercice3.BankAccount.test;
using FakeItEasy;
using NFluent;
using Xunit;

namespace Exercice3.BankAccountKata
{
	

    public class BanckAccountAcceptanceTest
    {
	    private StringPrinterDriverAdapter _stringPrinterDriverAdapter;

	    [Fact]
	    public void PrintStatementAccepatnce()
	    {
			string output = String.Empty;

			var service = Create();

			service.Deposit(1000);

			service.Withdraw(100);

			service.Deposit(500);

			service.PrintStatement();

			Check.That(_stringPrinterDriverAdapter.BuildPrintedLines())
				.Equals(new StringBuilder()
				    .AppendLine("DATE|AMOUNT|BALANCE")
				    .AppendLine("10/04/2015|500,00|1400,00")
				    .AppendLine("02/04/2015|-100,00|900,00")
				    .AppendLine("01/04/2015|1000,00|1000,00").ToString());
	    }

	    private BankAccount.main.BankAccount Create()
	    {
		    _stringPrinterDriverAdapter = new StringPrinterDriverAdapter();
		    return new BankAccount.main.BankAccount(
				new OperationRepository(A.Fake<ITimeProvider>()),
				new PrintService(_stringPrinterDriverAdapter));
	    }
    }
}
