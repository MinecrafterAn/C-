Console.WriteLine("Введите число: ");
int number = int.Parse (Console.ReadLine());
int number1 = 1;
while (number1 < number + 1)
{
    if (number1 %2 == 0)
    Console.Write (number1 + (","));
    number1 +=1;
}
