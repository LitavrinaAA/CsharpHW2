// Запишите программу, которая выводит третью цифру заданного числа
//или сообщает что третьей цифры нет

int InputN(String mes)
{
    System.Console.WriteLine(mes);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
bool CheckThreeDigit(int num)
{
    if (num / 100 > 0) //&& (num / 1000 == 0))
    {
        System.Console.WriteLine();
        return true;  }
    else
    {
        System.Console.WriteLine("третьей цифры нет");
        return false;
    }
}
void lastN(int number)
{
    
    //System.Console.WriteLine("третья цифра = " + number.ToString()[2]);
    int digLess = number;
    while(digLess / 1000 != 0){
        digLess = digLess / 10;
    }
    System.Console.WriteLine(digLess % 10);
}
void LastDig(int n)
{
    if (CheckThreeDigit(n))
        lastN(n);
}
string message = "Введите трехзначное число, а я выведу его третью цифру";
LastDig(InputN(message));