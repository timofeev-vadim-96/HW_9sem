//Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n
// m = 3, n = 2 -> A(m,n) = 29 - 

// p.s. Согласно определению Петер
// А(0,n) = n + 1
// A(m + 1, 0) = A(m, 1)
// A(m+1, n+1) = A(m, A(m+1,n))

System.Console.WriteLine("введите значение переменной M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите значение переменной N: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m<0 || n<0) return; //Чтобы соблюсти условие

int Ackerman (int m, int n)
{
    if (m==0) return n+1;
    else if (m>0 && n==0) return Ackerman(m-1,1);
    else return Ackerman(m-1, Ackerman(m, n-1));
}
System.Console.WriteLine(Ackerman(m, n)); 
