// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Clear();

int fibonacci1 = 0;
int fibonacci2 = 1;
 
Console.WriteLine("Количество элементов ряда Фибоначчи: ");
int n = Convert.ToInt32(Console.ReadLine());
 
int fibonacciSum = 0;
int count = 0;

while (count < (n - 2))
{
    fibonacciSum = fibonacci1 + fibonacci2;
    fibonacci1 = fibonacci2;
    fibonacci2 = fibonacciSum;
    count++;
    Console.Write($" {fibonacciSum}");
}