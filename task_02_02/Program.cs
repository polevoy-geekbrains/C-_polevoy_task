/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Пример: 645 -> 5    78 -> третьей цифры нет     32679 -> 6
*/
Console.WriteLine();
Console.Write("Введите число\t");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = (userNumber / 100);
if (result == 0)
{
    Console.Write("Третьей цифры нет");
}
else
{
    int thirdNumber = GetThirdNomber(userNumber);
    Console.WriteLine(thirdNumber);
}

static int GetThirdNomber(int k)
{
    while (k >= 1000) k /= 10;
    int d = k % 10;
    return d;
}
