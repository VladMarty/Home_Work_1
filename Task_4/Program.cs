// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int i = 1;
bool not = true;
Console.Clear();
Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
while (i <= num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;   
}
if (not)
{
    Console.WriteLine("Нет четных чисел!");
}
Console.WriteLine("Все четные числа от 1 до " + num);

