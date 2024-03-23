// Напишите программу, которая выводит третью с
// конца цифру заданного числа или сообщает, что
// третьей цифры нет.
// 456 => 6
// 7812 => 8
// 91 => Третьей цифры нет

int num = new Random().Next(0,10000);
System.Console.WriteLine(num);

int res = 0;
if (num < 100)
{
    System.Console.WriteLine($"Третьей цифры нет: {num}");
}
else
{
    while (num >= 100)
        {
            res = num % 10; // здесь мы отсекаем последнюю цифру
            num /= 10; // num является переменной счетчиком, когда мы делим число на 10, то уменьшаем его 
            System.Console.WriteLine($"num:{num}");
            System.Console.WriteLine($"Ответ:{res}");
            System.Console.WriteLine();
        }
}





