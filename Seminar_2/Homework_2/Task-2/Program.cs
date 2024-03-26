// Напишите программу, 
// которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

System.Console.Write("Введите координаты точки x: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты точки y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    System.Console.WriteLine("Ответ: 1");
}
else if (x < 0 && y > 0)
{
    System.Console.WriteLine("Ответ: 2");
}
else if (x < 0 && y < 0)
{
    System.Console.WriteLine("Ответ: 3");
}
else if (x > 0 && y < 0)
{
    System.Console.WriteLine("Ответ: 4");
}
else
{
    System.Console.WriteLine("Точка находится на оси координат");
}