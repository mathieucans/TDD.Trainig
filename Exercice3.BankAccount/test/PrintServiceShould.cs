using System;
using System.Text;
using Exercice3.BankAccount.main;
using Exercice3.BankAccountKata;
using NFluent;
using Xunit;

namespace Exercice3.BankAccount.test
{
	public class PrintServiceShould
	{
		private const string HEADER_LINE = "DATE|AMOUNT|BALANCE";
		private PrintService _printService;
		private StringPrinterDriverAdapter _printerDriver;

		public PrintServiceShould()
		{
			_printerDriver = new StringPrinterDriverAdapter();
			_printService = new PrintService(_printerDriver);
		}
		
		[Fact]
		public void should_print_the_header_first()
		{
			_printService.Print(new Statement());

			Check.That(_printerDriver.BuildPrintedLines()).Equals(
				new StringBuilder()
					.AppendLine(HEADER_LINE).ToString());
		}

		[Fact]
		public void should_print_each_Lines()
		{
			var statement = new Statement();
			statement.AddLine(DateTime.Parse("30/06/2015"), -10.0, 500);
			statement.AddLine(DateTime.Parse("20/06/2015"), 1000, 5000);

			_printService.Print(statement);

			Check.That(_printerDriver.BuildPrintedLines()).Equals(
				new StringBuilder()
					.AppendLine(HEADER_LINE)
					.AppendLine("30/06/2015|-10.00|500.00")
					.AppendLine("30/06/2015|1000.00|5000.00").ToString());
		}
	}
}