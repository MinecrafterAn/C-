int number = new Random().Next(100, 1000);
Console.WriteLine("Случайное число: " + number);
int seconddigit = number%100 / 10;
Console.WriteLine ("Вторая цифра данного числа: " + seconddigit);