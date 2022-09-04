// Программа которая опр. четность или не четность числа.
Console.Write("Введите число для проверка четности:  ");
int a = Convert.ToInt32(Console.ReadLine());
if ( a % 2 == 0 )
    Console.WriteLine ( "Четное");
else
    Console.WriteLine ( "Не четное");
