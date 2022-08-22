// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int[] NewArray(int[] array,int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите значение элемента массива:");
        array[i] = int.Parse(Console.ReadLine()!);
    }

    return array;
}

int PositiveNumber(int[] array,int size)
{
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if(array[i] > 0)
            count ++;
    }

    return count;
}

Console.WriteLine("Введите количество элементов в массиве: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];
NewArray(array,size);
Console.WriteLine("[" + string.Join(", ", array) + "]");
int pos = PositiveNumber(array,size);
Console.WriteLine("Количество чисел больше 0: " + pos);

