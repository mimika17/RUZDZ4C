// Зaдача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

try
{
Console.WriteLine("Введите число А");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b=Convert.ToInt32(Console.ReadLine());
void formula(int num,int step)
{

Console.WriteLine ($" {num} в степени {step} равно {Math.Pow(num,step)}");
}
int formula2(int numb, int ctep)
{
int voz=numb;
for (int i = 1; i < ctep; i++)
{
    voz=voz*numb;
}
Console.WriteLine($" {numb} в степени {ctep} равно {voz}");
return voz;
}

Console.WriteLine("Первый вариант решения задачи:");
formula(a,b);
Console.WriteLine("Второй вариант решения задачи:");
formula2(a,b);

}

catch
{
    Console.WriteLine("Введите целые числа!!!");
}

