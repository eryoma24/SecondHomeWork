int Prompt (string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Prompt("Введите цифру дня недели => ");
if (ValidateWeekday(weekDay))
{
    if(IsWeekend(weekDay))
    {
        System.Console.WriteLine("Наконец-то выходной");
    }
    else
    {
        System.Console.WriteLine("Придётся поработать");
    }
}