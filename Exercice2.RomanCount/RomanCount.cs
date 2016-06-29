using System;

namespace Exercice2.RomanCount
{
	public class RomanCount
	{
		public string Convert(int arabic)
		{
			var result = "";		

			var converter = new RomanConverter(1,"I");

			while (arabic > 0)
			{
				if (arabic >= 50)
				{
					result += "L";
					arabic -= 50;
				}
				if (arabic < 40 && arabic >= 10)
				{
					result += "X";
					arabic -= 10;
				}
				if (arabic < 10 && arabic >= 9)
				{
					result += "IX";
					arabic -= 9;
				}
				if (arabic < 9 && arabic >= 5)
				{
					result += "V";
					arabic -= 5;
				}
				if (arabic < 5 && arabic >= 4 )
				{
					result += "IV";
					arabic -= 4;
				}
				if (arabic < 4 && arabic >= 1)				
				{
					result += "I";
					arabic--;
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
