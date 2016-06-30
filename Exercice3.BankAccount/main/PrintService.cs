using System;
using Exercice3.BankAccount.main;

namespace Exercice3.BankAccountKata
{
	public class PrintService : IPrintService
	{
		private readonly IPrinterDriver _printerDriver;

		public PrintService(IPrinterDriver printerDriver)
		{
			_printerDriver = printerDriver;
		}

		public void Print(Statement statement)
		{
			_printerDriver.PrintLine("DATE|AMOUNT|BALANCE");
			foreach (var statementLine in statement.Lines)
			{
				_printerDriver.PrintLine("{0:dd/MM/yyyy}|{1:.00}|{2:.00}", 
					statementLine.Date,					
					statementLine.Amount,
					statementLine.Balance);
			}
		}
	}
}