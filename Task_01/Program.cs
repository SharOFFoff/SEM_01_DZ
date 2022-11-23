Console.Clear();
Console.Write("Введите число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
    Console.Write( $" max = {n} ");
if (n < m)
    Console.Write( $" max = {m} ");
if (n == m)
    Console.Write( $"{n} = {m} ");