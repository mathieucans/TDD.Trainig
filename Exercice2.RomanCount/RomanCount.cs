using System;

namespace Exercice2.RomanCount
{
	public class RomanCount
	{
		public string Convert(int arabic)
		{
			var result = "";
			if (arabic > 2)
			{
				result += "I";
			}
			if (arabic > 1)
			{
				result += "I";
			}
			if (arabic > 0)
			{
				result += "I";
			}

			return result;
		}
	}
}
