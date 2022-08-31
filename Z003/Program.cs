// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int n =8;
int[] arr = FillArray(n);
PrintArray(arr);
int[] FillArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}
int[] PrintArray(int []number)
{
int a=number.Length;
for(int i=0; i<a; i++)
{
    if (i!=a-1 && i!=0) Console.Write($"{number[i]}, ");
    else if ( i==0)  Console.Write($" [ {number[i]}, ");
    else Console.WriteLine($"{number[i]} ]");
}
return number;
}