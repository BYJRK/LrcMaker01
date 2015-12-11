using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LrcMakerTest01
{
    class Time
    {
        private double time = 0;
        public int Minutes
        {
            get
            {
                return (int)(time / 60);
            }
        }
        public int Seconds
        {
            get
            {
                return (int)((time - 60 * Minutes));
            }
        }
        public int Milliseconds
        {
            get
            {
                return (int)Math.Round(1000 * (time - Math.Floor(time)));
            }
        }
        public int ApproxMilliseconds
        {
            get
            {
                return (int)(1000 * Math.Round((double)Milliseconds / 1000, 2));
            }
        }
        public double ActualSeconds
        {
            get
            {
                return time;
            }
            set
            {
                time = value;
            }
        }
        public string Info
        {
            get
            {
                return string.Format("{0:00}:{1:00}.{2:000}", Minutes, Seconds, Milliseconds);
            }
        }
        public string ApproxInfo
        {
            get
            {
                return string.Format("{0:00}:{1:00}.{2:000}", Minutes, Seconds, ApproxMilliseconds);
            }
        }
        // 输入类似186.34秒（3分6秒340毫秒，00:03:06.340）这样的信息
        public Time(double value)
        {
            time = value;
        }
        // 输入类似00:03:06.340这样的信息
        public Time(string value)
        {
            if (TryParse(value))
            {
                Parse(value);
            }
        }
        public static bool TryParse(string value)
        {
            // 总共被:.符号分成几部分
            Regex r1 = new Regex(@"[:.]");
            string[] numbers = r1.Split(value);
            int c1 = numbers.Count();

            // 总共有几组数字
            Regex r2 = new Regex(@"\d+");
            MatchCollection mc = r2.Matches(value);
            int c2 = mc.Count;

            if (c1 == 3)
            {
                if (c2 == 3)
                    return true;
            }
            else if (c1 == 4)
            {
                if (c2 == 4)
                    return true;
            }
            return false;
        }
        public static Time Parse(string value)
        {
            Regex r = new Regex(@"\d+");
            MatchCollection mc = r.Matches(value);
            double milliseconds = 0;
            if (mc.Count == 4)
            {
                int hour = int.Parse(mc[0].ToString());
                int minute = int.Parse(mc[1].ToString());
                int second = int.Parse(mc[2].ToString());
                milliseconds = hour * 3600 + minute * 60 + second;
            }
            else if (mc.Count == 3)
            {
                int minute = int.Parse(mc[0].ToString());
                int second = int.Parse(mc[1].ToString());
                milliseconds = minute * 60 + second;
            }
            string mill = mc[mc.Count - 1].ToString();
            double milli = double.Parse(mill) / Math.Pow(10, mill.Length);
            milliseconds += milli;
            return new Time(milliseconds);
        }
        public static Time Parse(double value)
        {
            return new Time(value);
        }

        public static Time operator +(Time time1, Time time)
        {
            return new Time(time1.ActualSeconds + time.ActualSeconds);
        }
        public static Time operator -(Time time1, Time time)
        {
            return new Time(time1.ActualSeconds - time.ActualSeconds);
        }

    }
}
