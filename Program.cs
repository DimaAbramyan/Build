using System;
using System.Diagnostics;


class Program
{
    int Func(int x)
    {
        return x * x - x;
    }
    void Main(string[] args)
    {
        int a = 4;
        Debug.Assert(Func(a) == 12);
        a = 10;
        Debug.Assert(Func(a) == 90);
        a = 2;
        Debug.Assert(Func(a) == 2);

        Debug.Assert(false);
    }
}
