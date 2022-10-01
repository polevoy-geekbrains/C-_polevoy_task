/* Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Пример 3, 5 -> 243 (3⁵) 2, 4 -> 16
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

int number = getNumberFromUser("Введите целое число возводимое в степень:\t");
int powerNumber = getNumberFromUser("Введите степень числа:\t");
int numberResult = number;
for (int i = 1; i < powerNumber; i++)
{
    numberResult = numberResult * number;
}
Console.Write($"{number} в степени {powerNumber} равно {numberResult}");
