// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] num1 = num.ToString().Select(x => x - '0').ToArray();

int sum = 0;
for (int count = 0; count < num1.Length; count++)
{
    sum = sum + num1[count];
}

Console.WriteLine($"Cумма цифр в числе {num} = {sum}");