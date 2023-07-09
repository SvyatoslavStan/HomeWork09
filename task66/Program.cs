// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum(int m, int n)
{
    if (m==n)
    return n;
    else return m + sum(m + 1, n);
}

Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {sum(m,n)}");



// Console.WriteLine("Введите число M:");
// int numberM = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число N:");
// int numberN = int.Parse(Console.ReadLine());

// //Метод нахождения суммы натуральных элементов в промежутке от M до N
// void NumberSum (int numberM, int numberN, int sum)
// {
//     if (numberM < numberN) 
//     {
//         sum = sum + (numberM++);
//         return;
//     }
//     Console.Write($"Сумма натуральных элементов в промежутке от {numberM} до {numberN}: {sum}"); 
//     NumberSum(numberM, numberN, sum);
// }

// NumberSum(numberM, numberN, 0);