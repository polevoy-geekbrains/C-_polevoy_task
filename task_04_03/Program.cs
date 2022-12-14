/* Задача 29: 
Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .
Пример 5 -> [1, 2, 5, 7, 19]    3 -> [6, 1, 33]
*/
int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}
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
int lengthArray = getNumberFromUser("Введите длинну одномерного массива:\t");
int[] currentArray = getRandomArray(lengthArray, 1, 99);
printArray(currentArray);

