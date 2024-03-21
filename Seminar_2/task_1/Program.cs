// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81


// ПЕРВЫЙ СПОСОБ - генерация случайного числа

int num = new Random().Next(100,1000);
System.Console.WriteLine(num);

int num_1 = num % 10;
// так получаем правое число, т.е. первое

int num_2 = num / 100;
// так мы получаем левое число, т.е. третье

System.Console.WriteLine(num_2 + "" + num_1); // первый способ склеивания 
System.Console.WriteLine(num_2 * 10 + num_1); // второй способ математический

int result = num_2 * 10 + num_1;
System.Console.WriteLine($"{num} -> {result}"); // первый способ вывода результата

int result_2 = Convert.ToInt((num_2 + "" + num_1));
System.Console.WriteLine($"{num} -> {result_2}"); // второй способ вывода результата