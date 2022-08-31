// Написать программу сортировки массива от большего к меньшему. 
// Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.
try
{

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
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

void SelectionSort(int[] array)
{

for (int i = 0; i < array.Length-1; i++)
{
    int maxPosition=i;
for (int j = i+1; j < array.Length; j++)
{
    
if(array[j]>array[maxPosition]) maxPosition=j;

}


int temporary=array[i];
array[i]=array[maxPosition];
array[maxPosition]=temporary;

}


}
}
catch
{
    Console.WriteLine("Введите целые числа!!!");
}
