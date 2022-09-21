//Задача 10: Напишите программу, которая принимает на вход трёхзначное
//число и на выходе показывает вторую цифру этого числа.
int A;
Console.Clear();
Console.Write("Введите трехзначное число: ");
A=Convert.ToInt32(Console.ReadLine());
Link1:
if (A>=100 && A<1000)
{
   Console.Write(A/10%10);
}
else 
{  Console.Write("ОШИБКА! Введите трехзначное число: ");
   A=Convert.ToInt32(Console.ReadLine());
   goto Link1;}
   
