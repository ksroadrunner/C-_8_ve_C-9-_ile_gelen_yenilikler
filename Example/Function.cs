using System;
using System.Threading.Tasks;

namespace Example
{
    public class Function
    {
        public string Func_X(int a)
            => $"-> {a} <-";

        public string Func_XX(int a)
        {
            //var dt = DateTime.Now;

            //var y = 1;
            //var h = $"{dt:yyyyMMHH}";
            //var x = $@"\{y}";
            //var xx = $"\\{y}";

            return $"-> {a} <-";
        }

        public Task<string> Func_X2(int a)
        {
            return Task.Run<string>(() => $"-> {a} <-");
        }

        public async Task<string> Func_X3(int a)
        {
            return $"-> {a} <-";
        }

        public void Run()
        {
            Func<int, string> x = (a) =>
            {
                return $"-> {a} <-";
            };
            CallMe(x);

            Func<int, string> xx = Func_X;
        }

        public void CallMe(Func<int, string> func)
        {

        }
    }
}