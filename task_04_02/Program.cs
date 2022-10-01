/*  Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Пример 452 -> 11    82 -> 10    9012 -> 12
*/
int getNumberFromUser(string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result < 1)
    {
        Console.Write($"Ошибка ввода! Ожидается целое число больше нуля. {userInformation} ");
    }
    return result;
}
int number = getNumberFromUser("Введите целое число больше нуля:\t");
int sumNumbers = 0;
    while (number > 0)
    {
       sumNumbers = sumNumbers + number % 10;
       number = number /10 ;
    }

Console.Write($"Сумма цифр в числе равна {sumNumbers}");
