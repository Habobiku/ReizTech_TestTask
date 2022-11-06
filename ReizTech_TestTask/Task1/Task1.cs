using System;
using System.Reflection;

namespace ReizTech_TestTask
{
    public static class Task1
    {
        private static int СalcAngle(int hour, int minute)
        {
            if (hour == 12)
                hour = 0;
            if (minute == 60)
            {
                minute = 0;
                hour += 1;
                if (hour > 12)
                    hour = hour - 12;
            }

            int hour_angle = (int)(0.5 * (hour * 60 + minute));
            int minute_angle = (int)(6 * minute);

            int angle = Math.Abs(hour_angle - minute_angle);

            angle = Math.Min(360 - angle, angle);

            return angle;
        }

        public static void Start()
        {
            Console.WriteLine("Enter time in 12 hours format." +
                "\nExample: 12:30");
            string? hourAndMinute = Console.ReadLine();

            Time time = new Time(hourAndMinute);

            Console.WriteLine("Angle between hours arrow and minutes arrow: " + СalcAngle(time.Hour, time.Minute) + " degrees");
        }
    }
}

