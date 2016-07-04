using System;

namespace Exercice2.RomanCount
{
	public class RomanCount
	{
		public string Convert(int arabic)
		{
			var result = "";		

			while (arabic > 0)
			{
				var roman = "";
				int offset = arabic;
				if (arabic >= 1)
				{
					roman = "I";
					offset = 1;
				}				
				if (arabic >= 5)
				{
					roman= "V";
					offset = 5;
				}
				if (arabic >= 10 )
				{
					roman= "X";
					offset = 10;
				}

				result += roman;
				arabic -= offset;
			}

			return result;
		}
	}
}
