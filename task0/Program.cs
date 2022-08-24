// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m == 0)
{
    Console.WriteLine("Недопустимое значение");
    return;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент: ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}
int[] result = FillArray(m);


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]}");
}

int CountPosNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

PrintArray(result);
int res = CountPosNumber(result);
Console.WriteLine($"Количество положительных чисел: {res}");
