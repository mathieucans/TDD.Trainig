using NFluent;
using Xunit;

namespace Exercice1
{
    public class NamingConvention
    {
	    [Fact]
	    public void naming_should_clarify_behaviours()
	    {
		    var myName = "Mathieu";
		    Check.That(myName).Equals("Mathieu");
	    }
    }
}
