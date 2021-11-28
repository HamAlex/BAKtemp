using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var input = 0;
            Process p = new Process();
            p.StartInfo.FileName = "exportLegacy.exe";
            p.StartInfo.Arguments = " -user " + input + " -role user";
            p.Start();
            var TODO = 0;
            var unencrypted = "password";
        }
    }
}
