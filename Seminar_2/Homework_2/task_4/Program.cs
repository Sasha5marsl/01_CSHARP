// Задача 4: Напишите программу, 
// которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

System.Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    System.Console.WriteLine(num);
}
else
{
    while (num > 0)
{
    int cut = num % 10;
    num /= 10;
    if (num > 0)
    {
        System.Console.Write(cut + ",");
    }
    else
    {
        System.Console.WriteLine(cut);
    }
}
}