// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

void Check(int number)
{
	if (number >= 10000 & number < 100000)
	{
		int first = number / 10000;
		int second = number % 10;

		if (first == second)
		{
			number = number / 10;
			int third = (number / 100) % 10;
			int fourth = number % 10;
			if (third == fourth)
				Console.WriteLine("Да");
		}
		else
			Console.WriteLine("Нет");
	}
	else
		Console.WriteLine("Некорректное число!");
}

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Check(number);