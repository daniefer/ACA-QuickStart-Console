using System;

namespace ACA_QuickStart_Console
{
	public class HelloWorldController
	{
		public string Name { get; private set; }

		public void PrintHelloWorld()
		{
			Console.WriteLine("Hello World!");
		}

		public void AskForName()
		{
			Console.WriteLine("What is your name?");
			Name = Console.ReadLine();
		}

		public void PrintHello()
		{
			Console.WriteLine($"Hello {Name}");
		}
	}
}
