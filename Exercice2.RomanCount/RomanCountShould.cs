using NFluent;
using Xunit;

namespace Exercice2.RomanCount
{
	public class RomanCountShould
	{
		private readonly RomanCount _romanCount = new RomanCount();

		[Theory]
		[InlineData(1, "I")]
		[InlineData(2, "II")]
		[InlineData(3, "III")]
		public void convert_arabic_to_roman(int arabic, string roman)
		{		
			Check.That(_romanCount.Convert(arabic)).Equals(roman);
		}
	}
}