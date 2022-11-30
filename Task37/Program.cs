// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] ProductOfElems(int[] array)
{
    int sizeProd = array.Length / 2;
    if (array.Length % 2 == 1) sizeProd += 1;
    int[] arrayProduct = new int[sizeProd];
    for (int i = 0; i < sizeProd; i++)
    {
        if (i == array.Length - 1 - i)
            arrayProduct[i] = array[i];
        else
            arrayProduct[i] = array[i] * array[array.Length - 1 - i];
    }
    return arrayProduct;
}

int[] arr = CreateArrayRndInt(5, 1, 10);
PrintArray(arr);
int[] productOfArr = ProductOfElems(arr);
PrintArray(productOfArr);