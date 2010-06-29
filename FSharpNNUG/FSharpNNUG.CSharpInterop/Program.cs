using System;

namespace FSharpNNUG.CSharpInterop
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Fibonacci.nthFibonacci(10));
			Console.ReadKey();
		}
	}
}
