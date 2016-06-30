using System.Text;
using Exercice3.BankAccount.main;
using NFluent;
using Xunit;

namespace Exercice3.BankAccountKata
{
	public class PrintServiceShould
	{
		private PrintService _printService;
		private StringPrinterDriverAdapter _printerDriver;

		public PrintServiceShould()
		{
			_printerDriver = new StringPrinterDriverAdapter();
			_printService = new PrintService();
		}

		
		[Fact]
		public void should_print_the_header_first()
		{
			_printService.Print(new Statement());

			Check.That(_printerDriver.BuildPrintedLines()).Equals("DATE|AMOUNT|BALANCE");
		}
	}

	internal class StringPrinterDriverAdapter : IPrinterDriver
	{
		private StringBuilder _builder;

		public string BuildPrintedLines()
		{
			return _builder.ToString();
		}

		public StringPrinterDriverAdapter()
		{
			_builder = new StringBuilder();
		}

		public void PrintLine(string line)
		{
			_builder.AppendLine(line);
		}
	}


}