using System;

namespace Exercice2.RomanCount
{
	public class RomanCount
	{
		public string Convert(int arabic)
		{
			var result = "";

			RomanConverter converter = null;
			var converters = new[]
			{
				new RomanConverter(1, "I"),
				new RomanConverter(4, "IV"),
				new RomanConverter(5, "V"),
				new RomanConverter(9, "IX"),
				new RomanConverter(10, "X"),
				new RomanConverter(50, "L"),
			};

			if (arabic > 0)
			{
				if (arabic >= 50)
				{
					converter = converters[5];
				}
				if (arabic < 40 && arabic >= 10)
				{
					converter = converters[4];
				}
				if (arabic < 10 && arabic >= 9)
				{
					converter = converters[3];
				}
				if (arabic < 9 && arabic >= 5)
				{
					converter = converters[2];
				}
				if (arabic < 5 && arabic >= 4)
				{
					converter = converters[1];
				}
				if (arabic < 4 && arabic >= 1)				
				{
					converter = converters[0];
				}				
			}

			if (converter != null)
			{
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
