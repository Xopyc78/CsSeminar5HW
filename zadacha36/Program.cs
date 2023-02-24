//  Задача 36: Задайте одномерный массив, заполненный случайными числами.
//   Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] GetArray(int size)
{
    int[] result = new int[size]; 
        for (int i = 0; i < result.Length; i++) 
    {
        result[i] = new Random().Next(-100,100);
    }
    return result;
    }
int[] array=GetArray(10);
int sum=0;
for (int i = 1; i < array.Length; i+=2)
{
    sum=sum+array[i];
}
Console.WriteLine($"В массиве [{String.Join("; ",array)}] сумма элементов из нечётных позиций равна {sum}");