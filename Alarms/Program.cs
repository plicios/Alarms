using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alarms
{
    class Program
    {
        private static void RunCountAlarmsAndPrint(int[] volume, int S)
        {
            Console.WriteLine(CountAlarms(volume, S));
            Console.WriteLine();
        }

        private static void Tests()
        {
            RunCountAlarmsAndPrint(new[] { 5, 2, 4 }, 13);

            RunCountAlarmsAndPrint(new[] { 5, 2, 4 }, 3);

            RunCountAlarmsAndPrint(new[] { 1 }, 10000);

            RunCountAlarmsAndPrint(new[] { 42, 68, 35, 1, 70, 25, 79, 59, 63, 65, 6, 46, 82, 28, 62, 92, 96, 43, 28, 37, 92, 5, 3, 54, 93, 83, 22, 17, 19, 96, 48, 27, 72, 39, 70, 13, 68, 100, 36, 95, 4, 12, 23, 34, 74, 65, 42, 12, 54, 69 }, 9999);
        }

        private static void RealData()
        {
            RunCountAlarmsAndPrint(new[] { 42, 68, 35, 1, 70, 25, 79, 59, 63, 65, 6, 46, 82, 28, 62, 92, 96, 43, 28, 37, 92, 5, 3, 54, 93, 83, 22, 17, 19, 96, 48, 27, 72, 39, 70, 13, 68, 100, 36, 95, 4, 12, 23, 34, 74, 65, 42, 12, 54, 69 }, 500);
            RunCountAlarmsAndPrint(new[] { 42, 68, 35, 1, 70, 25, 79, 59, 63, 65, 6, 46, 82, 28, 62, 92, 96, 43, 28, 37, 92, 5, 3, 54, 93, 83, 22, 17, 19, 96, 48, 27, 72, 39, 70, 13, 68, 100, 36, 95, 4, 12, 23, 34, 74, 65, 42, 12, 54, 69 }, 700);
            RunCountAlarmsAndPrint(new[] { 42, 68, 35, 1, 70, 25, 79, 59, 63, 65, 6, 46, 82, 28, 62, 92, 96, 43, 28, 37, 92, 5, 3, 54, 93, 83, 22, 17, 19, 96, 48, 27, 72, 39, 70, 13, 68, 100, 36, 95, 4, 12, 23, 34, 74, 65, 42, 12, 54, 69 }, 900);
            RunCountAlarmsAndPrint(new[] { 42, 68, 35, 1, 70, 25, 79, 59, 63, 65, 6, 46, 82, 28, 62, 92, 96, 43, 28, 37, 92, 5, 3, 54, 93, 83, 22, 17, 19, 96, 48, 27, 72, 39, 70, 13, 68, 100, 36, 95, 4, 12, 23, 34, 74, 65, 42, 12, 54, 69 }, 900);
        }

        static void Main(string[] args)
        {
            //Tests();
            RealData();

            Console.ReadKey();
        }

        static int CountAlarms(int[] volume, int S)
        {
            int i = 0;
            while (S > 0)
            {
                S -= volume[i % volume.Length];
                i++;
            }

            return i;
        }
    }
}
