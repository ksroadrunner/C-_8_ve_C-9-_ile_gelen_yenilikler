using System;

namespace Example
{
    public class Interface
    {
        public abstract class BaseLogger
        {
            public void Info(string x)
            {
                Console.WriteLine(x + " Beep Beep!");
            }

            public abstract void Error();
        }

        public interface ILogger
        {
            void Info(string x)
            {
                Console.WriteLine(x + " Beep Beep!");
            }
            void Error();
        }

        public class Test : ILogger
        {
            //void ILogger.Info(string x)
            //{
            //    Console.WriteLine(x);
            //}

            public void Info(string x)
            {

            }

            public void Error()
            {
                Console.WriteLine("Error ! Abstract ? :/");
            }
        }

        public void Run()
        {
            ILogger logger = new Test();
            logger.Info("RoadRunner");
            logger.Error();
        }
    }
}