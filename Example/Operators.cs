using System.Collections.Generic;

namespace Example
{
    public class Operators
    {
        public void Run()
        {
            //int? x = null;
            //var y = x ?? 5;

            List<int> numbers = null;
            numbers ??= new List<int>();

            if (numbers == null)
            {
                numbers = new List<int>();
            }
            // ------

            int? i = null;
            numbers.Add(i ??= 17); // i = 17
            numbers.Add(i ?? 17); // i = null
        }
    }
}
