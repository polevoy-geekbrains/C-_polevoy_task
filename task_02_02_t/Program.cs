/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Пример: 645 -> 5    78 -> третьей цифры нет     32679 -> 6
*/
Console.WriteLine("Введите число\t");
string userNumber = (Console.ReadLine());
int size = userNumber.Length;
if (size < 3)
{
   Console.WriteLine("Третьей цифры нет"); 
}
else
{
// Вариант с отбрасыванием лишних символов
/* 
userNumber = userNumber.Remove(0, 2);
string tempNumber = userNumber.Substring(0, userNumber.Length -(userNumber.Length-1));
Console.WriteLine(tempNumber);
*/
// Вариант с поиском третьего символа в ASCII кодировке (это самое быстрое решение задачи)
int tempNumber = userNumber[2];
Console.WriteLine(Convert.ToChar(tempNumber));
}
