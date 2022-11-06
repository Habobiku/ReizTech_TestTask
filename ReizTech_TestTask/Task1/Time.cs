using System;
using System.Xml.Linq;

namespace ReizTech_TestTask
{
    public class Time
    {

        private int _hour;
        private int _minute;

        public int Hour { get => _hour; set => _hour = value; }
        public int Minute { get => _minute; set => _minute = value; }
        public Time(string? hourAndMinute)
        {
            SetHourAndMinute(hourAndMinute);
        }

        private void SetHourAndMinute(string? hourAndMinute)
        {
            if (!string.IsNullOrWhiteSpace(hourAndMinute))
            {
                var index = hourAndMinute.IndexOf(':');
                int _hour = Convert.ToInt16(index > 0 ? hourAndMinute.Substring(0, index) : hourAndMinute);
                int _minute = Convert.ToInt16(index > 0 ? hourAndMinute.Substring(index + 1) : hourAndMinute);

                if (_hour < 0 || _minute < 0 || _hour > 12 || _minute > 60)
                {
                    throw new ArgumentNullException($"{hourAndMinute} Wrong input", hourAndMinute);
                }
                else
                {
                    Hour = _hour;
                    Minute = _minute;
                }
            }
            else if (hourAndMinute == null)
            {
                throw new ArgumentNullException($"{hourAndMinute} Wrong input", hourAndMinute);
            }
            else
            {
                throw new ArgumentException($"{hourAndMinute} Wrong input", hourAndMinute);
            }
        }
    }
}

