using System;

namespace Exercice2.RomanCount
{
	public class RomanCount
	{
		public string Convert(int arabic)
		{
			var result = "";		

			var converter = new RomanConverter(1,"I");

			if (arabic > 0)
			{
				if (arabic >= 50)
				{
					result += "L" + Convert(arabic - 50);
				}
				if (arabic < 40 && arabic >= 10)
				{
					result += "X" + Convert(arabic - 10);
				}
				if (arabic < 10 && arabic >= 9)
				{
					result += "IX" + Convert(arabic - 9);
				}
				if (arabic < 9 && arabic >= 5)
				{
					result += "V" + Convert(arabic - 5);
				}
				if (arabic < 5 && arabic >= 4)
				{
					result += "IV" + Convert(arabic - 4);
				}
				if (arabic <= 3)				
				{
					result += "I" + Convert(arabic - 1);
				}
				
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
