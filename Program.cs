using System;

namespace task_5
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = "Пупкин";
			string lastName = "Вася";
			Console.WriteLine($"первоначальное значение name - {name}; первоначальное значение lastName - {lastName}");
			string exchange = lastName;
			lastName = name;
			name = exchange;
			Console.WriteLine($"теперь значение name - {name}; теперь значение lastName - {lastName}");
		}
	}
}
