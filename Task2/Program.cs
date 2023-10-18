// Задача 27

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);

    return number;
}
int number = ReadInt("Введите число");
int summa = 0;
while (number > 0)
    {
    summa = summa + number% 10;
    number = number /10;
    }
Console.WriteLine(summa);
