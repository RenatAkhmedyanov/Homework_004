Console.WriteLine("Программа, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.");


Console.WriteLine("Введите число");
decimal input = decimal.Parse(Console.ReadLine()!);

while (input % 1 > 0)
{
    input *= 10;
}

long newInput = (long)input;

long GetNumberOfDigits(long newInput)
{
    int count = 0;
    do
    {
        newInput /= 10;
        count++;
    } while (newInput > 0);
    return count;
}
long result = GetNumberOfDigits(newInput);
Console.WriteLine("Количество цифр в числе: " + result);
