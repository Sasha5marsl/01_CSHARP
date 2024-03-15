// Напишите программу, которая на вход принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.

System.Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// alt+shift+(стрелка вниз) - копирует и вставляет выделенный участок кода

if(number1 == number2 * number2)
{
    System.Console.WriteLine($"Квадрат числа {number2} равен {number1}");
}
else System.Console.WriteLine("Квадрат числа {0} НЕ равен {1}" , number2, number1);

// Ниже приведен пример конвертации 
// строковой переменнной, принятой из ввода в терминале, 
// затем преобразуем в целочисленную и снова в строку.

string number3 = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine(number3);
