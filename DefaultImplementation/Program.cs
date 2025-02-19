using System;

namespace DefaultImplementation
{
    interface Ilogger
    {
        void Writelog(string message);
        void WriteError(string error)
        {
            Writelog("Error: " + error);
        }
    }
    class ConsoleLogger : Ilogger
    {
        public void Writelog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Ilogger logger = new ConsoleLogger();   // 인터페이스로 선언
            logger.Writelog("This is a log message");
            logger.WriteError("This is an error message");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.Writelog("System up");
            //clogger.WriteError("System down");    컴파일 에러, WriteError는 Ilogger에만 있음
        }
    }
}
