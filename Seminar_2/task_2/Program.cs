// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// Первый способ решения через матеатическую функцию Math.Pow

int num = new Random().Next(100,1000);
System.Console.WriteLine(num);

int num_1 = num % 100; // результат деления по модолю является остаток от деления
int num_2 = num_1 / 10;
int num_3 = num_1 % 10;

System.Console.WriteLine(num_1);
System.Console.WriteLine(num_2);
System.Console.WriteLine(num_3);

System.Console.WriteLine($"результат:{Math.Pow(num_2,num_3)}");

// Решение при помощи цикла

int num = new Random().Next(100,1000);
Console.WriteLine(num);

int num_1 = num % 100;
int num_2 = num_1 / 10;
int num_3 = num_1 % 10;

Console.WriteLine($"num_1:{num_1}");
Console.WriteLine($"num_2:{num_2}");
Console.WriteLine($"num_3:{num_3}");
Console.WriteLine($"результат:{Math.Pow(num_2,num_3)}");

int i = 0;
int c = 1;
Console.WriteLine(); // добавляет пустую строку

while (i < num_3)
{
    c *= num_2;
    Console.WriteLine(c);
    i++;
}


