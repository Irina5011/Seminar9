// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные- 
// числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int M = Prompt("Введите число M => ");
int N = Prompt("Введите число N => ");


NaturalRow(M, N);

void NaturalRow(int M, int N)
{
    if (M > N) return;
    {
        if (M % 2 == 0)
            Console.WriteLine(M + " ");
        NaturalRow(M + 1, N);

    }

}
