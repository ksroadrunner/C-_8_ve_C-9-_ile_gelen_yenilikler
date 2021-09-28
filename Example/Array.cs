using System;

namespace Example
{
    public class Array
    {
        public void Run()
        {
            // https://docs.microsoft.com/tr-tr/dotnet/csharp/whats-new/csharp-8#indices-and-ranges
            var members = new[]
            {
                "RoadRunner",   // 0 - ^8
                "Sertaç",       // 1 - ^7
                "İpek",         // 2 - ^6
                "Ayşegül",      // 3 - ^5
                "Gökhan",       // 4 - ^4
                "Berra",        // 5 - ^3
                "Okan",         // 6 - ^2
                "Caner",        // 7 - ^1
            };                  // 8 - ^0

            var teamName = members[0];
            var teacher = members[^1];
            var teamMembers = members[1..7];
            var allMembers = members[..];
            var singleMembers = members[^3..];

            var rnd = new Random();
            var jackpot = new Range(rnd.Next(0, 3), rnd.Next(3, 7));
            var luckyMembers = members[jackpot];
        }
    }
}