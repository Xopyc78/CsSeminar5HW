// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// Используйте NextDouble().
double[] GetArray(int size)
{
    double[] result = new double[10]; 
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round(100*(new Random().NextDouble()));
    }
    return result;
}
double[] array = GetArray(10);
double max=array[0];
double min=array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>max)
    {
        max=array[i];
    }
    else if (array[i]<min)
    {
        min=array[i];
    }
}
double delta=max-min;
Console.WriteLine($" В массиве: [{String.Join("; ", array)}] макс. числом является {max}, мин. {min},  их разница равна {delta}");