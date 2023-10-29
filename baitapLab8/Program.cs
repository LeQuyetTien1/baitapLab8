using System;
using System.Collections.Generic;

class Generic<T>
{
    T[] a;
    int count;
    public Generic(int n)
    {
        a = new T[n];
        count = 0;
    }
    public void Add(T value)
    {
        if (count < a.Length)
        {
            a[count] = value;
            count++;
        }

    }
    public void Display()
    {
        Console.Write("Mang gom cac phan tu: ");
        foreach(var i in a)
        {
            Console.Write(i+" ");
        }
        Console.WriteLine();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so phan tu cho mang: ");
        int n = int.Parse(Console.ReadLine());
        Generic<int> a = new Generic<int>(n);
        Console.WriteLine("Nhap cac phan tu so nguyen cho mang: ");
        for(int i = 0; i < n; i++)
        {
            int x = int.Parse(Console.ReadLine());
            a.Add(x);
        }
        a.Display();
        Console.ReadKey();

        Generic<char> b = new Generic<char>(n);
        Console.WriteLine("Nhap cac phan tu ky tu cho mang: ");
        for(int i = 0; i < n; i++)
        {
            char x = char.Parse(Console.ReadLine());
            b.Add(x);
        }
        b.Display();
    }
}
