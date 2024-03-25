// Поиск и вывод на экран максимального числа из массива

int n = 5;
int[] arr = { 65, 5, 6, 332, 90 };
int i = 0;
int max = arr[0];

while (i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i++;
}
System.Console.WriteLine(max);

max = arr[0];

for(int j = 0; j < n; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
System.Console.WriteLine(max);

max = arr[0];

foreach (int e in arr)
{
    if (e > max)
    {
        max = e;
    }
}
System.Console.WriteLine(max);