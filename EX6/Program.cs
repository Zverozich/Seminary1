﻿/*5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
2 -> " -2, -1, 0, 1, 2"*/
Console.Clear();

/*Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = (-1) * n; i <= n; i++) //Читается так: для счетчика i = -1 минус для того чтобы диапазон начинался от кранего отрицательного числа, пока счетчик не станет больше введенного числа, после выполнения опреации присвоить счетчику значение i+1)
Console.Write($"{i} ");*/

//Теперь через цикл While

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n <= 0)
    {Console.Write("Напишите число выше нуля ");
    n = Convert.ToInt32(Console.ReadLine());}
int i = -1 *n ;
Console.WriteLine("Результирующий диапазон:");
while (i <= n)
    {
    Console.Write($"{1 * i} ");
    i = i + 1;
    }
