//Вывод всех целых чисел из числа N
Console.Write("Введите число:  ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <=n; i+=2 )
{
    if ( i == n || i == n - 1)
        Console.Write(i);
    else
        Console.Write(i + ", ");
}
// Сам я не особо допер, пытался все сделать через IF, по этому уже переписал на разборе ДЗ.