// /* Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Пример A (3,6,8); B (2,1,-7), -> 15.84      A (7,-5, 0); B (1,-1,9) -> 11.53
// */
// Console.WriteLine("\n Задача 21");
// int x1 = Coordinate("x", "A");
// int y1 = Coordinate("y", "A");
// int z1 = Coordinate("z", "A");
// int x2 = Coordinate("x", "B");
// int y2 = Coordinate("y", "B");
// int z2 = Coordinate("z", "B");

// int Coordinate(string coorName, string pointName)
// {
//     Console.Write($"Введите координату {coorName} точки {pointName}: ");
//     return Convert.ToInt16(Console.ReadLine());
// }

// double Decision(double x1, double x2, 
//                 double y1, double y2, 
//                 double z1, double z2){
//   return Math.Sqrt(Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));
// }

// double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine($"Длина отрезка  {segmentLength}");
int [] arr1 = new int[3];
int i = 0;
for (i = 0; i < 3; i++)
{
      Console.Write($"Введите {i + 1} координату точки А:\t"); 
      arr1[i] = Convert.ToInt32(Console.ReadLine()); 
}
int [] arr2 = new int[3];
int j = 0;
for (j = 0; j < 3; j++)
{
      Console.Write($"Введите {j + 1} координату точки B:\t"); 
      arr2[j] = Convert.ToInt32(Console.ReadLine()); 
}
double segmentLength = Math.Sqrt(Math.Pow((arr2[0]-arr1[0]), 2) + Math.Pow((arr2[1]-arr1[1]), 2) + Math.Pow((arr2[2]-arr1[2]), 2));
Console.WriteLine($"Длина отрезка  {Math.Round (segmentLength, 2)}");
