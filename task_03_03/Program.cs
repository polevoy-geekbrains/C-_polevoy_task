
// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   Console.WriteLine($"{cube.Length} ");
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }
// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube + 1];
// Cube(arry);
// PrintArry(arry);
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

int number = getNumberFromUser("Введите целое число N > 0:\t");
int cube = 0;
int i = 1;
for (i = 1; i < (number + 1); i++)
{
    cube = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($"{cube} ");
}
