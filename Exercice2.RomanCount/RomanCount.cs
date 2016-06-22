using System;
using System.Linq;

namespace Exercice2.RomanCount
{
	public class RomanCount
	{
		public string Convert(int arabic)
		{
			var result = "";

			var rules = new []
			{
				new ConvertionRule(1,4,"I"),
				new ConvertionRule(4,5,"IV"),
				new ConvertionRule(5,9,"V"),
				new ConvertionRule(9,10,"IX"),
				new ConvertionRule(10,50,"X"),
				new ConvertionRule(50,100,"L"),
			};

			while (arabic > 0)
			{				
				var rule = rules.First(r => r.Match(arabic));

				result = rule.Apply(result);
				arabic = rule.Decrment(arabic);		
			}

			return result;
		}
	}

	public class ConvertionRule
	{
		private int _from;
		private int _to;
		private string _converted;

		public ConvertionRule(int from, int to, string converted)
		{
			_from = from;
			_to = to;
			_converted = converted;
		}
		public bool Match(int arabic)
		{
			
			return arabic < _to && arabic >= _from;
		}


		public string Apply(string roman)
		{
			return roman + _converted;
		}

		public int Decrment(int arabic)
		{
			return arabic - _from;
		}

	}	
}
