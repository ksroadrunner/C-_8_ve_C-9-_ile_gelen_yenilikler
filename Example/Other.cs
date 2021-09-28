using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Example
{
    public class Other
    {
        public void Run1()
        {
            // var fileInfo = new FileInfo("BeepBeep.txt").OpenRead();
            // using (fileInfo)
            // {
            // }

            // var fileInfo = new FileInfo("BeepBeep.txt").OpenRead();
            // fileInfo.Dispose();

            using var x = new FileInfo("BeepBeep.txt").OpenRead();

            // Actions
        }

        #region Run2
        public record Person(string FirstName, string LastName);
        public record PersonExtend(string FirstName, string LastName)
        {
            public string PhoneNumber { get; set; }
        }

        public void Run2()
        {
            var p = new Person("test", "test 2");
            var persons = new List<Person>()
            {
                new Person("Ali", "Veli"),
                new Person("ABC", "DEF")
            };

            var personExtend = new PersonExtend("Test", "Test2")
            {
                PhoneNumber = "1234"
            };
        }
        #endregion

        #region Run3
        public class Student
        {
            public string Name { get; init; }
            public string Surname { get; init; }
            public string Phone { get; set; }
        }

        public void Run3()
        {
            var student = new Student()
            {
                Name = "Caner",
                Surname = "Sarıgül"
            };
            // Can't change after initialization - student.Name = "Okan";
            //student.Name = "Okan";
            //student.Phone = "1234";
        }
        #endregion

        public void Run4()
        {
            var x = new Other();
            if (!(x is null))
            {

            }

            if (x is not null)
            {
            }

            object xx = 0;
            if (xx is int number)
            {

            }
        }

        public void Run5()
        {
            // SQL to LINQ ?
            string name = "RoadRunner";
            //if (name == "RoadRunner" || name == "BeepBeep!")
            //{

            //}

            //if(new[] { "RoadRunner", "BeepBeep!" }.Contains(""))
            //{

            //}

            if (name is "RoadRunner" or "BeepBeep!" or "Test")
            {

            }

            // && name is ("RoadRunner" or "XYZ") and ("Mahmut" or "Tuncer")
            int salary = 5000;
            if (salary is >= 100 and <= 60000)
            {

            }
        }

        public void Run6()
        {
            var abc = new List<string>();
            List<string> list = new();
            list = new() { "Test", "Test2" };

            var arr = new[] { 1, 2, 3, new object() };
            var arr2 = new[] { 1, 2, 3, 4L };
            var arr3 = new[] { 1, 2D, 3L, 4f };

            var x = default(int);

            //Run7(list);
            //Run7(new());
            //Run7(default);
            //Run8("asdsa");
            //Run8(123);
        }

        public void Run7(List<string> items)
        {
            items.Add("1");
            items.Add("2");
            items.Add("3");
        }
    }
}