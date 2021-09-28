using System;

namespace ConsoleApp1
{
    static class Program
    {
        static void Main(string[] args)
        {
            // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/configure-language-version
            var exArr = new Example.Array();
            exArr.Run();

            var exFunc = new Example.Function();
            exFunc.Run();

            var exInt = new Example.Interface();
            exInt.Run();

            var exOpt = new Example.Operators();
            exOpt.Run();

            var exSwitch = new Example.SwitchCase();

            var exOth = new Example.Other();
            exOth.Run1();
            exOth.Run2();
            exOth.Run3();
            exOth.Run4();

            Console.ReadKey();
        }
    }
}