// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//первый способ
 try
 {
Console.WriteLine("Введите целое числo:");
int a=Convert.ToInt32(Console.ReadLine());
string str=Convert.ToString(a);
int formula(int num)
{
int sum = 0;
while (a>0)
{
int b = a%10;
a=a/10;
sum=sum+b;
}
Console.WriteLine($"Сумму цифр в {num} равна {sum}");
return sum;
}


string formula2(string num)
{
 int summ=0;
  int[] array=new int[num.Length] ;
 
 for (int i = 0; i < num.Length; i++)
 {
     array[i]= Convert.ToInt32(num[i].ToString());
      summ=summ+array[i];
 } 
 Console.WriteLine($"Сумму цифр в {num} равна {summ}");
return num;

}

Console.WriteLine("Первый вариант решения задачи:");
formula(a);
Console.WriteLine("Второй вариант решения задачи:");
formula2(str);
}
catch
{
    Console.WriteLine("Введите целые числа!!!");
}


