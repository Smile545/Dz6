// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Задайти длину массива ");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a];
int sum = 0;
for (int i = 0; i < a; i++)
{
    Console.WriteLine("Введите число массива ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine(sum);
