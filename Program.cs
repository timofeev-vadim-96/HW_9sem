// Задайте значение M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
System.Console.WriteLine("введите значение переменной M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите значение переменной N: ");
int N = Convert.ToInt32(Console.ReadLine());
string numbers (int A, int B)
{
    if (A==B) return B.ToString();
    return (A + ", " + numbers(A+1, B));
}
System.Console.WriteLine(numbers(M, N)); 
