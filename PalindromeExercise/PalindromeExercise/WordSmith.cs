using System;
using System.Linq;
namespace PalindromeExercise	
{
	public class WordSmith
	{
		public WordSmith()
		{
		}
		public bool IsAPalindrome(string kayak)
		{
			var reversed = "";
			for (int i = kayak.Length - 1; i >=  0; i--)
			{ reversed += kayak[i]; }
			if (reversed.ToLower() == kayak.ToLower())
			{ return true; }
			else
			{ return false; }
		}
	}
}

