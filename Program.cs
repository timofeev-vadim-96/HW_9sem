//Задача 66. Задайте значение значения М и N. Напишите программу, которая найдет сумму натуральных элементов 
// в промежутке от M до N.
// M = 4, N = 8 -> 30
System.Console.WriteLine("введите значение переменной M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите значение переменной N: ");
int N = Convert.ToInt32(Console.ReadLine());
int Sum (int A, int B)
{
    if (A==B) return B;
    return (A + Sum(A+1, B));
}
System.Console.WriteLine(Sum(M, N)); 
