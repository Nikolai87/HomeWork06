// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int M = ReadInt("сколько будет чисел");

CountPositiveNumbers(M);


int ReadInt(string argument)
{
	Console.Write($"введите {argument}: ");
	return int.Parse(Console.ReadLine()!);
}

void CountPositiveNumbers(int M)
{
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        int number = ReadInt("число");
        if (number > 0) {count++;}
    }
    Console.WriteLine($"положительных чисел: {count}");
}

