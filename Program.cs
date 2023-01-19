/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] GetArrayRandom( int Length)
{
    int[] arr = new int[Length];
    for(int i = 0; i< Length; i++)
    {
        arr[i] = new Random().Next( 0, 100);
    }
    return arr;
}

void showArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length -1)
        {
            Console.Write($"{array[i]},");
        }
        else
        {
            Console.Write($"{array[i]}]");
        }
    }
}
int[] array = GetArrayRandom(8);
showArray(array);