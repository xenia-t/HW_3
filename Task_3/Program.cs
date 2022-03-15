// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

Console.Write("Введите натуральное число N: ");
string numberN = Console.ReadLine();
int N = int.Parse(numberN);

if (N > 0)
{
	for (int i = 1; i <= N; i++)
	{
		Console.Write($"{Math.Pow(i,3)} ");
	}
}
else Console.WriteLine($"Введено некорректное значение. Число {N} не является натуральным");



