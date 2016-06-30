using System;
using System.Globalization;
using System.Text;
using Exercice3.BankAccountKata;

namespace Exercice3.BankAccount.test
{
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

		public void PrintLine(string line, params object[] args)
		{
			_builder.AppendLine(String.Format(new CultureInfo("en-us"), line, args));
		}
	}
}