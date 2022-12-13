//Задача 13: Напишите программу, которая выводит третью 
//цифру заданного 
//числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

    if (num < 100)
{
    Console.WriteLine($"третьей цифры нет ");   
}
    if (num > 100 && num < 999)
{
    int thirdNumber = (num / 1) % 10;
    
    Console.WriteLine($"третья цифра заданного числа {num} -> {thirdNumber}");
}
    if (num > 999 && num < 9999)
    {
     int thirdNumber = (num / 10) % 10;

         Console.WriteLine($"третья цифра заданного числа {num} -> {thirdNumber}");
    }