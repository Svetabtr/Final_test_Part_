/*
Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.
*/

Console.Clear();
Console.Write("Введите значения через запятую: ");

string readText = Console.ReadLine();
string[] text = readText.Split(", ");

string[] newMassive = GetNewMassive(text);
PrintMassive(newMassive);

string[] GetNewMassive(string[] massive)
{
    string[] newMassive = new string[massive.Length];
    int j = 0;

    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i].Length <= 3)
        {
            newMassive[j] = massive[i];
            j++;
        }
    }
    return newMassive;
}

void PrintMassive(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write(massive[i] + " ");
    }
}
