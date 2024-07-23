

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет
 


 Console.WriteLine("Введите первое значение:");
int firstValue = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе значение:");
int secondValue = Convert.ToInt32(Console.ReadLine()); 

if(firstValue == secondValue * secondValue) 
{
    Console.WriteLine("a = " + firstValue + ", b = " + secondValue + " => Да");
}
else
{
    Console.WriteLine($"a = {firstValue}, b = {secondValue} => Нет");
}

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

Console.Write("Введите целое положительное число: ");
long number = Convert.ToInt64(Console.ReadLine()); // number = 3

long i = -number; // i = -3
        // -1 <= 3
while (i <= number)
{
    //                  -1 
    System.Console.Write(i + " ");
    i++; // i = i + 1 // i += 1
}

for (int i = -number; i <= number; i++)
{
    System.Console.Write(i + " ");
}



// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
// 1004
//  TRUE         И   FALSE  
if (99 < number && number < 1000)
{
    int leftDigit = number / 100;
    int rightDigit = number % 10;
    int result = leftDigit + rightDigit;
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Число НЕ трехзначное");
}