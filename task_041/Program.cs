// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int[] array = new int[100];
Random randomFilling = new Random();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = randomFilling.Next(-10, 10);
    if (array[i]%2 == 0)
    {
        count++;
    }
}

Console.WriteLine('[' + string.Join(", ", array ) + ']');
Console.WriteLine($"Количество четных чисел в массиве равно: {count}");