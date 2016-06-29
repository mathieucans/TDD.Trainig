using System;
using System.Linq;

namespace Exercice2.RomanCount
{
	public class RomanCount
	{
		public string Convert(int arabic)
		{
			var result = "";

			var converters = new[]
			{
				new RomanConverter(1, "I"),
				new RomanConverter(4, "IV"),
				new RomanConverter(5, "V"),
				new RomanConverter(9, "IX"),
				new RomanConverter(10, "X"),
				new RomanConverter(40, "XL"),
				new RomanConverter(50, "L"),
				new RomanConverter(90, "XC"),
				new RomanConverter(100, "C"),
				new RomanConverter(400, "CD"),
				new RomanConverter(500, "D"),
				new RomanConverter(900, "CM"),
				new RomanConverter(1000, "M"),
			};

			if (arabic > 0)
			{
				var converter = converters.Last(
					c => arabic >= c.Arabic);

				result = String.Concat(
					result,
					converter.Roman,
					Convert(arabic - converter.Arabic));
			}

			return result;
		}
	}

	public class RomanConverter
	{
		public int Arabic { get; set; }
		public string Roman { get; set; }

		public RomanConverter(int arabic, string roman)
		{
			Arabic = arabic;
			Roman = roman;
		}
	}
}
