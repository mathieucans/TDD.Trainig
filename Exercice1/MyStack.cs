using System;
using System.Collections.Generic;

namespace Exercice1
{
	public class MyStack
	{
		private Stack<object> _stack;

		public MyStack()
		{
			_stack = new Stack<object>();
		}

		public object Pop()
		{
			if (IsEmpty()) throw new MyException();

			return _stack.Pop();
		}

		public void Push(object anObject)
		{
			_stack.Push(anObject);
		}

		private bool IsEmpty()
		{
			return _stack.Count == 0;
		}
	}

	public class MyException : Exception
	{
	}
}