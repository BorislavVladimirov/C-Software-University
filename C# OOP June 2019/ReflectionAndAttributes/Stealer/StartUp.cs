using System;
using System.Diagnostics;

public class StartUp
{
    public static void Main()
    {
        string name = "Ivan";

        Console.WriteLine(name[2]);
        Spy spy = new Spy();
        string result = spy.StealFieldInfo("Hacker", "username", "password");
        Console.WriteLine(result);
    }
}
