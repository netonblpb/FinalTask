// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.

Console.Clear();

string[] startarray = new string[] { "hello", "2", ";-)", "work", "list", "Moscow", "((", "1"};
int len = 0;

for (int i = 0; i < startarray.Length; i++)
{
    if (startarray[i].Length <= 3) len ++;
}

string[] resultarray = new string[len];
len = 0;

for (int i = 0; i < startarray.Length; i++)
{
    if (startarray[i].Length <= 3)
    {
        resultarray[len] = startarray[i];
        len++;
    }
}