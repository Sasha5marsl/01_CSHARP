// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

// Пример:
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ] 


void PrintMass(char[] collection)
{
    foreach (var item in collection)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}


string n = Console.ReadLine()!; 
// просим ввести строку с консоли
char[] mass = new char[n.Length];
// создаем новый массив типа char с длиной равной длине строки

for(int i=0; i<n.Length; i++)
{
    mass[i] = n[i];
    // проходимся по элементам массива типа char, заменяя каждый на элемент строки
}

// После того, как цикл завершился, мы выводм полученный массив на консоль
PrintMass(mass);