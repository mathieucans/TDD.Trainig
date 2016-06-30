using System;
using System.Collections.Generic;

namespace Exercice3.BankAccount.main
{
	public class Statement
	{
		private List<StatementLine> _lines;

		public Statement()
		{
			_lines = new List<StatementLine>();
		}

		public IEnumerable<StatementLine> Lines
		{
			get { return _lines; }
		}

		public void AddLine(DateTime date, double amount, int balance)
		{
			_lines.Add(new StatementLine(date, amount, balance));
		}
	}

	public class StatementLine
	{
		public DateTime Date { get; private set; }
		public double Amount { get; private set; }
		public int Balance { get; private set; }

		public StatementLine(DateTime date, double amount, int balance)
		{
			Date = date;
			Amount = amount;
			Balance = balance;
		}
	}
}