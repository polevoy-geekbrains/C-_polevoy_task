/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Пример 6 -> да  7 -> да 1 -> нет
*/
Console.WriteLine();
Link1:
Console.Write("Введите номер дня недели:\t");
int userNumber = Convert.ToInt32(Console.ReadLine());
switch (userNumber)
{
    case 1:
    Console.WriteLine("Понедельник не является выходным днем");
    break;
    case 2:
    Console.WriteLine("Вторник не является выходным днем");
    break;
    case 3:
    Console.WriteLine("Среда не является выходным днем");
    break;
    case 4:
    Console.WriteLine("Четверг не является выходным днем");
    break;
    case 5:
    Console.WriteLine("Пятница не является выходным днем");
    break;
    case 6:
    Console.WriteLine("Суббота - выходной день");
    break;
    case 7:
    Console.WriteLine("Воскресенье - выходной день");
    break;
    default:
    Console.WriteLine($"{userNumber} Не является номером дня недели попробуйте еще раз");
    goto Link1;
}
