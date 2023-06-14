int getDayNumber()
{
    Console.WriteLine("Введите, пожалуйста, число от 1 до 7");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void checkDay(int dayNumber)
{
    if (dayNumber >= 1 && dayNumber <= 5)
    {
        Console.WriteLine("Этот день не является выходным");
    }
    else 
    {
         Console.WriteLine("Этот день является выходным");
    }
}

int dayNumber = getDayNumber();
checkDay(dayNumber);
