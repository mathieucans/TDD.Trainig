using System;

namespace Exercice3.BankAccount.main
{
	public class StatementLine
	{
		protected bool Equals(StatementLine other)
		{
			return Date.Equals(other.Date) && Amount.Equals(other.Amount) && Balance.Equals(other.Balance);
		}

		public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = Date.GetHashCode();
				hashCode = (hashCode*397) ^ Amount.GetHashCode();
				hashCode = (hashCode*397) ^ Balance.GetHashCode();
				return hashCode;
			}
		}

		public DateTime Date { get; private set; }
		public double Amount { get; private set; }
		public double Balance { get; private set; }

		public StatementLine(DateTime date, double amount, double balance)
		{
			Date = date;
			Amount = amount;
			Balance = balance;
		}

		public override bool Equals(object obj)
		{
			if (obj is StatementLine)
			{
				return Equals((StatementLine)obj);
			}
			return base.Equals(obj);
		}
	}
}