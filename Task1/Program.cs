// Задача 25

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string numb = Console.ReadLine();
    int number;
    number = int.Parse(numb);

    return number;
}
int numberA = ReadInt("Введите число A");
int numberB = ReadInt("Введите степень числа");
int stepen = 1;
for (int i =1; i <= numberB; i++ )
    {
    stepen = stepen * numberA;
    }
Console.WriteLine(stepen);
