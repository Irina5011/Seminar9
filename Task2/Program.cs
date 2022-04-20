// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

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

void NaturalRow(int M, int N, int sum = 0)
{
    if (M > N) return;
    {
        sum = sum + M;
    NaturalRow(M + 1, N);
    }
    Console.WriteLine(sum + " ");
}
     