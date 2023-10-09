using System.Diagnostics;
var sw = new Stopwatch();
sw.Start();
Console.Write("Введи размерность массива: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
int k = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-30,30);
    Console.WriteLine(arr[i]);
}
Console.WriteLine("Сортированый массив: ");
int temp = 0;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = i + 1; j < arr.Length; j++)
    {
        if (arr[i] > arr[j])
        {
            temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    Console.WriteLine(arr[i]);
}
sw.Stop();
Console.WriteLine($"StopWatch:{sw.Elapsed}");
Console.ReadLine();


