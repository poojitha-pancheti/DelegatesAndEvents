using System;

namespace DelegatesAndEvents
{
    class Program
    {
        //public delegate void WorkPerformedHandler(int hours, WorkType worktype);
        public delegate int WorkPerformedHandler(int hours, WorkType worktype);
        static void Main(string[] args)
        {
            WorkPerformedHandler del1 = new WorkPerformedHandler(WorkPerformed1);
            WorkPerformedHandler del2 = new WorkPerformedHandler(WorkPerformed2);
            WorkPerformedHandler del3 = new WorkPerformedHandler(WorkPerformed3);

            //DoWork(del1);

            //del1(5, WorkType.Golf);
            //del2(10, WorkType.GenerateReports);

            //del1 += del2;
            //del1 += del3;

            del1 += del2 + del3;

            //del1(10, WorkType.GoToMeetings);
           
            int finalHours = del1(10, WorkType.GenerateReports);
            Console.WriteLine(finalHours);
            
            Console.Read();
        }
        static void DoWork(WorkPerformedHandler del)
        {
            del(5, WorkType.GoToMeetings);
        }
        static int WorkPerformed1(int hours,WorkType workType)
        {
            Console.WriteLine("WorkPerformed1 called " + hours.ToString());
            return hours + 1;
        }
        static int WorkPerformed2(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed2 called " + hours.ToString());
            return hours + 2;
        }
        static int WorkPerformed3(int hours, WorkType workType)
        {
            Console.WriteLine("WorkPerformed3 called " + hours.ToString());
            return hours + 3;
        }
        public enum WorkType
        {
            GoToMeetings,
            Golf,
            GenerateReports
        }
    }
}
