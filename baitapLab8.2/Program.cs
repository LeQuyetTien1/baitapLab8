using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Sau khi swap: " + a + ", " + b);
        }
        Console.WriteLine("Nhap 2 phan tu a va b: ");
        int a = 6, b = 3;
        Swap<int>(ref a, ref b);
        char x = 'A', y = 'B';
        Swap<char>(ref x, ref y);
        string i = "abc", j = "xyz";
        Swap<string>(ref i, ref j);
    }
}