int getNewNumber()
{
    Console.WriteLine("Введите, пожалуйста, число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void print3Number(int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
       while (number > 999)
       {
        number = number / 10;
       }
       int thirdNumber = number % 10;

       Console.WriteLine(thirdNumber);
    }

}

int number = getNewNumber();
print3Number(number);
