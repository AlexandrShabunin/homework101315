//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//Например
//456 -> 5
//782 -> 8
//918 -> 1
//782/10=78%10=8

Console.WriteLine("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    int secondNumber = (num / 10) % 10;

    Console.WriteLine($"second digit in the number {num}->{secondNumber}");
}
else
    Console.WriteLine($"digit {num} three-digit");