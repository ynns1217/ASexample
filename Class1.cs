using System;
using System.Collections.Generic;
using System.Linq;
//p.232 7장 클래스

using System;

class Global
{
    public static int Count = 0;
}

class ClassA
{
    public ClassA()
    {
        Global.Count++;
    }
}
class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}

class MainApp
{
    static void Main()
    {
        Console.WriteLine($"Global.Count : {Global.Count}");

        new ClassA();
        new ClassA();
        new ClassB();
        new ClassB();

        Console.WriteLine($"Global.Count : {Global.Count}");
    }
}

