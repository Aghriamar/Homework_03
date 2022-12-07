// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
int Lenght(int number)
{
    int lenght = 0;
    while(number > 0)
    {
        number = number / 10;
        lenght++;
    }
    return lenght;
}
int Start(int num, int lenght, int i)
{
    for(int b = 0; b < i; b++)
    {
        num /= 10;
    }
    for(int a = 0; a < lenght - i; a++)
    {
        num %= 10;
    }
    return num;
}

int End(int num, int lenght, int i)
{
    for(int a = 0; a < lenght - i; a++)
    {
        num /= 10;
    }
    for(int b = 0; b < i; b++)
    {
        num %= 10;
    }
    return num;
}
bool Palindrome(int number)
{
    int lenght = 0;
    lenght = Lenght(number);
    for(int i = 0; i < lenght; i++)
    {
        if(Start(number, lenght - 1, i) != End(number, lenght - 1, i))
        {
            return false;
        }
    }
    return true;
}

Console.Write("Введите числа: ");
Console.WriteLine($"Полиндром: {Palindrome(Convert.ToInt32(Console.ReadLine()))}");
*/

// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double Coordinates(double xA, double xB, double yA, double yB, double zA, double zB)
{
    return Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
}
Console.Write("Введите координату x A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z B: ");
int zB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние: {Math.Round(Coordinates(xA, xB, yA, yB, zA, zB), 2)}");
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*

int a = 0;
string number = "";
Console.Write($"Введите число: ");
a = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    if(i == a)
    {
        number += Convert.ToString($"{Math.Pow(i, 3)}");
    }
    else
    {
        number += Convert.ToString($"{Math.Pow(i, 3)}, ");
    }
}
Console.WriteLine($"{number}");

*/