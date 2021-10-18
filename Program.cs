using System;
using static System.Console;

namespace Comparando_IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            var dia = DateTime.Now.DayOfWeek;

            if(dia == DayOfWeek.Sunday)
            {
                WriteLine($"Today is {DayOfWeek.Sunday}");
            }
            else if(dia == DayOfWeek.Monday)
            {
                WriteLine($"Today is {DayOfWeek.Monday}");
            }
            else if(dia == DayOfWeek.Tuesday)
            {
                WriteLine($"Today is {DayOfWeek.Tuesday}");
            }
            else if(dia == DayOfWeek.Wednesday)
            {
                WriteLine($"Today is {DayOfWeek.Wednesday}");
            }
            else if(dia == DayOfWeek.Thursday)
            {
                WriteLine($"Today is {DayOfWeek.Thursday}");
            }
            else if(dia == DayOfWeek.Friday)
            {
                WriteLine($"Today is {DayOfWeek.Friday}");
            }
            else
            {
                WriteLine($"Today is {DayOfWeek.Saturday}");
            }
        }
    }
}
