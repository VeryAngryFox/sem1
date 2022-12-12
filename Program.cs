// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Ведите число");
int num;
num = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < num; i += 2)
{
    Console.WriteLine(i);
}
Console.ReadKey();
