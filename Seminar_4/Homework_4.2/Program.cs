// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

System.Console.Write("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[n]; // создаем сам массив, пока пустой

int[] RandomMass(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        col[i] = new Random().Next(0,10);
    }
    return col;
}

void PrintMass(int[] coon)
{
    foreach (var item in coon)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int[] ReversalMass(int[] port)
{
    for (int i = 0; i < port.Length / 2; i++)
    {
        int temp = port[i];
        port[i] = port[port.Length - 1 -i];
        port[port.Length - 1 -i] = temp;
    }
    return port;
}

int[] mas = RandomMass(arr);
PrintMass(mas);
System.Console.WriteLine();

int[] mas2 = ReversalMass(mas);
PrintMass(mas);





