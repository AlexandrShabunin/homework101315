//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Enter day week : ");
int dayweek = Convert.ToInt32(Console.ReadLine());

switch (dayweek)
{
    case 1:
        Console.WriteLine("Monday - No");
        break;
    case 2:
        Console.WriteLine("Tuesday - No");
        break;
    case 3:
        Console.WriteLine("Wednesday - No");
        break;
    case 4:
        Console.WriteLine("Thursday - No");
        break;
    case 5:
        Console.WriteLine("Friday - No");
        break;
    case 6:
        Console.WriteLine("Saturday - Yes");
        break;
    case 7:
        Console.WriteLine("Sunday - Yes");
        break;
    default:
        Console.WriteLine("error number");
        break;
}