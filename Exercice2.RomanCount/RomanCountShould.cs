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
		[InlineData(5, "V")]
		[InlineData(4, "IV")]
		[InlineData(6, "VI")]
		[InlineData(7, "VII")]
		[InlineData(8, "VIII")]
		[InlineData(9, "IX")]
		[InlineData(10, "X")]
		[InlineData(11, "XI")]
		[InlineData(15, "XV")]
		[InlineData(20, "XX")]
		[InlineData(30, "XXX")]
		[InlineData(50, "L")]
		[InlineData(60, "LX")]
		[InlineData(88, "LXXXVIII")]
		[InlineData(100, "C")]
		[InlineData(500, "D")]
		[InlineData(1000, "M")]
		[InlineData(2499,"MMCDXCIX")]
		[InlineData(3949 ,"MMMCMXLIX")]
		[InlineData(3999, "MMMCMXCIX")]
		public void convert_arabic_to_roman(int arabic, string roman)
		{		
			Check.That(_romanCount.Convert(arabic)).Equals(roman);
		}
	}
}