// Программа которая сравнивает 2 числа.
Console.Write("Введите первое число:  ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write( "Введите второе число:  " );
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.Write (  a );
if (b > a)
    Console.Write (  b ); 
if (b == a)
    Console.Write ( "ERROR");