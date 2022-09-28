/* Задача 19 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Пример 14212 -> нет     12821 -> да     23432 -> да
*/
Console.Write("Введите пятизначное число:\t");
string? userNumber = (Console.ReadLine());
int arr = userNumber.Length;
if (arr == 5)
{
    if (userNumber[0] == userNumber[4] || userNumber[1] == userNumber[3])
    {
        Console.WriteLine($"{userNumber} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{userNumber} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {userNumber} - не является пятизначным числом");
}

