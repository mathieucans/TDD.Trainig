using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercice2.RomanCount
{
	public class RomanCount
	{
		public string Convert(int arabic)
		{
			var result = "";

			var rulesbuilder = new RulesCollecitonBuilder();
			var rules = rulesbuilder.Convert(1).With("I")
				.Convert(4).With("IV")
				.Convert(5).With("V")
				.Convert(9).With("IX")
				.Convert(10).With("X")
				.Convert(40).With("XL")
				.Convert(50).With("L")
				.Convert(90).With("XC")
				.Convert(100).With("C")
				.Convert(400).With("CD")
				.Convert(500).With("D")
				.Convert(900).With("CM")
				.Convert(1000).With("M")
				.Build();				

			while (arabic > 0)
			{				
				var rule = rules.First(r => r.Match(arabic));

				result = rule.Apply(result);
				arabic = rule.Decrment(arabic);		
			}

			return result;
		}
	}

	public class RulesCollecitonBuilder
	{
		private SortedList<int, Convertion> _conversions;

		public RulesCollecitonBuilder()
		{
			_conversions = new SortedList<int, Convertion>();
		}
		public Convertion Convert(int i)
		{
			var convertion = new Convertion(i, this);

			_conversions.Add(convertion.Arabic, convertion);

			return convertion;
		}

		public IEnumerable<ConvertionRule> Build()
		{
			var result = new List<ConvertionRule>();
			Convertion last = null;
			foreach (var conversion in _conversions.Values)
			{
				if (last != null)
				{
					result.Add(new ConvertionRule(
						last.Arabic,
						conversion.Arabic,
						last.Roman));					
				}
				last = conversion;
			}
			if (last != null)
			{
				result.Add(new ConvertionRule(
					last.Arabic,
					1000000,
					last.Roman));
			}
			return result;
		}
	}

	public class Convertion
	{
		public int Arabic { get; private set; }
		private readonly RulesCollecitonBuilder _builder;
		public string Roman { get; private set; }

		public Convertion(int i, RulesCollecitonBuilder builder)
		{
			Arabic = i;
			_builder = builder;
		}

		public RulesCollecitonBuilder With(string with)
		{
			Roman = with;
			return _builder;
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
