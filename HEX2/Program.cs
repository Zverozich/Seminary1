/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.Clear();
Console.Write("Введите число №1: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №3: ");
int z = Convert.ToInt32(Console.ReadLine());
if (x > y || x > z)
    Console.WriteLine($"В результате наибольшее число: {x}");
else if (y > z || y > x)
    Console.WriteLine($"В результате наибольшее число: {y}");
else if (z > x || z > y)
    Console.WriteLine($"В результате наибольшее число: {z}");