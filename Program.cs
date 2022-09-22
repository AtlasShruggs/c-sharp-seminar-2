while (true)
{
Console.WriteLine();
Console.WriteLine("Введите номер задачи");
int exerciseNum = int.Parse(Console.ReadLine());
if (exerciseNum == 10)
{   Console.WriteLine("Введите трехзначное число");
    string num = Console.ReadLine();
    char[] numArr = num.ToCharArray(0, num.Length);

    if (num.StartsWith("-") & num.Length >= 4)
    {
        Console.WriteLine(numArr[2]);
    }
    else if (num.Length >= 3)
    {
        Console.WriteLine(numArr[1]);
    }
    else
    {
        Console.WriteLine("Число не соответствует условию");
    }
}
else if (exerciseNum == 13)
{
    Console.WriteLine("Введите число");
    string number = Console.ReadLine();
    if (number.StartsWith("-"))
    {
        if (number.Length < 4)
        {
            Console.WriteLine("Третьей цифры нет");
        }
        else{
            Console.WriteLine(number[3]);
        }
    }
    else if (number.Length < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        Console.WriteLine(number[2]);
    }
}
if (exerciseNum == 15)
{
    Console.WriteLine("ВВедите номер дня недели");
    int dayNum = int.Parse(Console.ReadLine());
    if (dayNum == 6 | dayNum == 7)
    {
        Console.WriteLine("Выходной");
    }

    else if (dayNum > 7 | dayNum < 1)
    {
        Console.WriteLine("Дней недели с таким номером не бывает");
    }
    else
    {
        Console.WriteLine("Рабочий");
    }
}}