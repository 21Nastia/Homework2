
// Напишите программу, которая принимает на вход
// координаты двух точек и находит растояние между ними в 3D пространстве
//  A (3,6,8); B (2,1,-7), -> 15.84
//  A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите число А1");
string stX1 = Console.ReadLine();
int x1 = int.Parse(stX1);

Console.WriteLine("Введите число А2");
string stY1 = Console.ReadLine();
int y1 = int.Parse(stY1);

Console.WriteLine("Введите число А3");
string stZ1 = Console.ReadLine();
int z1 = int.Parse(stZ1);

Console.WriteLine("Введите число В1");
string stX2 = Console.ReadLine();
int x2 = int.Parse(stX2);

Console.WriteLine("Введите число В2");
string stY2 = Console.ReadLine();
int y2 = int.Parse(stY2);

Console.WriteLine("Введите число В3");
string stZ2 = Console.ReadLine();
int z2 = int.Parse(stZ2);

int a = (x2 - x1);
int b = (y2 - y1);
int c = (z2 - z1);

double a2 = Math.Pow(a, 2);
double b2 = Math.Pow(b, 2);
double c2 = Math.Pow(c, 2);

double abc = Math.Sqrt(a2 + b2 + c2);
Console.WriteLine(abc);

