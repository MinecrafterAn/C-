Console.WriteLine("Введите первое число:");
int number1 = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе число:");
int number2 = int.Parse (Console.ReadLine());
int max = number1;
int min = number2;
if (number1 < number2)
{
    max = number2;
    min = number1;
}
Console.Write("Наибольшим числом является: " + max);
Console.Write(", а наименьшим числом является: " + min);