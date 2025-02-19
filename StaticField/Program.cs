using System;

class Global
{
    public static int COUNT = 0;
}

class ClassA
{
    public ClassA()
    {
        Global.COUNT++;
    }
}

class ClassB
{
    public ClassB()
    {
        Global.COUNT++;
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Global.COUNT : {Global.COUNT}");
        
        new ClassA();
        new ClassA();
        new ClassB();
        new ClassB();

        Console.WriteLine($"Global.COUNT : {Global.COUNT}");
    }
}

