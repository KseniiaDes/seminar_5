// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

bool FindNumber(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) return true;
    }
    return false;
}

bool FindNumber1(int number, int[] array)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            res = true;
            break;
        }
    }
    return res;
}

Console.Write("Введите число для поиска в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArrayRndInt(8, -10, 10);
PrintArray(arr);
bool findNumber = FindNumber(num, arr);
Console.WriteLine(findNumber ? $"Число {num} присутствует в массиве" : $"Число {num} отсутствует в массиве");

bool findNumber1 = FindNumber1(num, arr);
Console.WriteLine(findNumber1 ? $"Число {num} присутствует в массиве" : $"Число {num} отсутствует в массиве");