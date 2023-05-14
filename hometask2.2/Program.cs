Console.WriteLine ("Введите число: ");
int number = int.Parse (Console.ReadLine());
int step = 1;
int checkstep = number;
while (checkstep > 9)
{
    checkstep = checkstep / 10;
    step = step + 1;
}
if (step < 3)
{
    Console.WriteLine("Введенное вами число имеет меньше трех цифр, повторите ввод: ");
}
else
{
while (step > 3)
{
    number = number/10;
    step = step - 1;
}
number = number%10;
Console.WriteLine (number);
}