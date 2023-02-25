// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a=0;
int sum = 0;

int i=10;
int j=1;
while (i< number*i)
{


    a = (number % i) / j;
    sum += a;

    i*=10;
    j*=10;
}
Console.WriteLine(sum);
