using System;

namespace Example
{
    public class SwitchCase
    {
        public enum RoadRunnerMembers : int
        {
            Okan = 1,
            Ipek = 2,
            Sertac = 3,
            Gokhan = 4,
            Berra = 5,
            Aysegul = 6,
            Caner = 7
        };

        public string GetTeamMemberId(RoadRunnerMembers member) =>
            member switch
            {
                RoadRunnerMembers.Aysegul => "Ayşegül",
                RoadRunnerMembers.Ipek => "İpek",
                RoadRunnerMembers.Berra => "Berra",

                _ => throw new Exception(":)")
            };

        public RoadRunnerMembers GetMember(string name, string surname)
            => (name.ToLower(), surname) switch
            {
                ("okan", "Tiryaki") => RoadRunnerMembers.Okan,
                ("caner", "Sarıgül") => RoadRunnerMembers.Caner,
                ("gökhan", "Ergün") => RoadRunnerMembers.Gokhan,
                ("sertaç", "Yıldırım") => RoadRunnerMembers.Sertac,
                _ => throw new Exception(":)")
            };

        public record Student(string Name, string Surname, int Age);
        public RoadRunnerMembers GetStudentId(Student student) =>
            student switch
            {
                { Name: "Gökhan", Surname: "Ergün", Age: 10 } => RoadRunnerMembers.Gokhan,
                { Name: "Gökhan", Surname: "Ergün", Age: >20 and <30 } => RoadRunnerMembers.Gokhan,
                { Name: "Okan", Surname: "Tiryaki" } => RoadRunnerMembers.Okan,
                { Name: "İpek", Surname: "Erten" } => RoadRunnerMembers.Ipek,
                { Name: "Berra", Surname: "X" } => RoadRunnerMembers.Berra,
                _ => throw new Exception("Bla bla...")
            };

        public void Run()
        {


            //bool homeless = false;
            //var x = RoadRunnerMembers.Okan;

            //switch (x)
            //{
            //    case RoadRunnerMembers.Okan when 1 == 2:
            //        break;

            //    case RoadRunnerMembers.Okan:
            //        break;
            //}

            //switch (x)
            //{
            //    case RoadRunnerMembers.Okan:
            //    case RoadRunnerMembers.Ipek:
            //        if (1 == 2)
            //        {

            //        }
            //        else
            //        {

            //        }
            //        break;
            //}
        }
    }
}