// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int InputN()
{
    System.Console.WriteLine("Введите трехзначное число, а я покажу его вторую цифру");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

//check
void FindSecond(int num){
if ((num/100 > 0) && (num/1000 == 0)){
    //System.Console.WriteLine("трехзначное");
    
    System.Console.WriteLine();
    System.Console.WriteLine((num/10)%10);
}
else
{
    System.Console.WriteLine("не трехзначное");
}
}
int n = InputN();
FindSecond(n);