int getNumber()
{
    Console.WriteLine("Введите, пожалуйста, число");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int print2Number(int number1)
{
    int num = (number1/10) % 10;
    return num;
}

int number1 = getNumber();
int number = print2Number(number1);
Console.WriteLine(number);
