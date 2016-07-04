using System;
using NFluent;
using Xunit;

namespace Exercice1
{
    public class StackShould
    {
	    private readonly object AN_OBJECT;


	    public StackShould()
	    {
		    AN_OBJECT = new object();
	    }

	    [Fact]
	    public void pop_the_last_pushed_object()
	    {
		    var stack = new MyStack();

		    stack.Push(AN_OBJECT);

		    Check.That(stack.Pop()).Equals(AN_OBJECT);
	    }

	    [Fact]
	    public void throw_an_exception_if_popped_when_empty()
	    {
			var stack = new MyStack();
			stack.Push(AN_OBJECT);
		    stack.Pop();

		    Check.That(() => stack.Pop()).Throws<MyException>();
	    }
    }

	
}
