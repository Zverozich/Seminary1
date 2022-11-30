/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
5 -> Пятница */
Console.Clear();

Console.Write("Программа определения дня недели по введенному числу ");
int number_of_the_week = Convert.ToInt32(Console.ReadLine());
while (number_of_the_week < 1 || number_of_the_week >7)
    {Console.WriteLine("Вы ошиблись, попробуйте снова.");
    number_of_the_week = Convert.ToInt32(Console.ReadLine());}
if (number_of_the_week == 1)
    Console.WriteLine("Понеделеник");
else if (number_of_the_week == 2)
        Console.WriteLine("Вторник");
else if (number_of_the_week == 3)
        Console.WriteLine("Среда");
else if (number_of_the_week == 4)
        Console.WriteLine("Четверг");
else if (number_of_the_week == 5)
        Console.WriteLine("Пятница");
else if (number_of_the_week == 6)
        Console.WriteLine("Суббота");
else
    Console.WriteLine("Воскресенье");




