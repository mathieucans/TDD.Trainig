using Exercice3.BankAccount.main;
using Exercice3.BankAccountKata;
using NFluent;
using Xunit;

namespace Exercice3.BankAccount.test
{
	public class PrintServiceShould
	{
		private const string HEADER_LINE = "DATE|AMOUNT|BALANCE\r\n";
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

			Check.That(_printerDriver.BuildPrintedLines()).Equals(HEADER_LINE);
		}
	}
}