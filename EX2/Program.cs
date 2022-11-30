Console.Clear();

Console.WriteLine("Программа оределения высокосного года");
Console.Write("Введите год: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x % 400 == 0 || x % 100 != 0 && x % 4 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");