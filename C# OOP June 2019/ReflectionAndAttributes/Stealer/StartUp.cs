using System;
using System.Diagnostics;

public class StartUp
{
    public static void Main()
    {
        Spy spy = new Spy();
        string result = spy.StealFieldInfo("Hacker", "username", "password");
        Console.WriteLine(result);
    }
}
