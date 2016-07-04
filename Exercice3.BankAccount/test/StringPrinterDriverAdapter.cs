using System;
using System.Globalization;
using System.Text;
using Exercice3.BankAccountKata;

namespace Exercice3.BankAccount.test
{
	internal class StringPrinterDriverAdapter : IPrinterDriver
	{
		private StringBuilder _builder;
		private string _culture;

		public string BuildPrintedLines()
		{
			return _builder.ToString();
		}

		public StringPrinterDriverAdapter(string culture)
		{
			_builder = new StringBuilder();
			_culture = culture;
		}

		public void PrintLine(string line, params object[] args)
		{
			_builder.AppendLine(String.Format(new CultureInfo(_culture), line, args));
		}
	}
}