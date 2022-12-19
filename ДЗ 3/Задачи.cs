/*Задача 19
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да*/

/*void Palindrome (int num)
{
    int one = num/10000;
    int two = (num/1000)%10;
    int four = (num/10)%10;
    int five = num%10;
    Console.WriteLine($"{one},{two},{four},{five}");
    if (one>9)
    {
    Console.WriteLine($"Число {num} не пятизначное");
    }
    else
    {
    if (one==five && two==four)
    {
        Console.WriteLine($"Число {num} является палиндромом");
    }
    else
    {
    Console.WriteLine($"Число {num} не является палиндромом");
    }
    }
}
Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32 (Console.ReadLine());
Palindrome(N);
*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*void Coordinats( double x1, double y1,double z1, double x2,double y2, double z2)
{
   Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2)),2));
}
Console.WriteLine("введите x1=");
double x1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите y1=");
double y1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите z1=");
double z1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите x2=");
double x2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите y2=");
double y2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите z2=");
double z2=Convert.ToDouble(Console.ReadLine());
Coordinats(x1,y1,z1,x2,y2,z2);
*/

/*Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

void Cube(int N)
{
    if (N<1)
    {
        Console.WriteLine("Вы ввели неправильные данные");
    }
    int index=1;
    while(index < N+1) 
    {
        Console.WriteLine($"{index} -> {Math.Pow(index,3)}");
    index=index+1;
    }
}
Console.WriteLine("Введите число N=");
int x=Convert.ToInt32(Console.ReadLine());
Cube(x);