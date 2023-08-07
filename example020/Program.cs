// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int InputN(String mes)
{
    
    System.Console.WriteLine(mes);
    System.Console.WriteLine("(ну мало ли... а вдруг повезет и пн тоже выходной...)");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
bool IsItDayOfWeek(int n)
{
    if ((n >= 1) && (n <= 7))
        return true;
    else
        return false;
}
void IsWeekend(int n)
{
    if (IsItDayOfWeek(n))
    {
        if ((n == 6) || (n == 7))
            System.Console.WriteLine("да");
        else
            System.Console.WriteLine("нет");
    }
    else
    {
        System.Console.WriteLine("У нас нет такого дня недели... Наверно ты с Юпитера...");
    }
}
string message = "Введите день недели и я скажу выходной ли это";
IsWeekend(InputN(message));
