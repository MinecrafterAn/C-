Console.WriteLine ("Введите номер дня недели от 1 до 7: ");
int numberday = int.Parse (Console.ReadLine());
if (numberday < 6)
{
    Console.WriteLine("К сожалению это будний день...");
}
else
{
    Console.WriteLine("Поздравляем! Это выходной!");
}