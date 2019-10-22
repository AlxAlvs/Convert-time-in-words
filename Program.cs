using System;

namespace ConvertTimeInWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a integer for hours.");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a integer for minutes.");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(timeInWords(hours, minutes));
            Console.ReadLine();
        }

        static string timeInWords(int h, int m)
        {
            string hour = "";
            string minutes = "";

            hour = TimeConvert(Format(h));
            minutes = TimeConvert(Format(m));

            string result = "";

            if (minutes == "zero")
            {
                result = hour + " o' clock";
            }
            else if (m > 0 && m < 30)
            {
                result = minutes + " minutes" + " past " + hour;
                if (minutes == "one")
                {
                    result = minutes + " minute" + " past " + hour;
                }

                if (m == 15)
                {
                    result = minutes + " past " + hour;
                }
            }
            else if (m >= 30)
            {
                int nextHour = h + 1;

                if (h == 24)
                {
                    nextHour = 1;
                }
                else if (h == 23)
                {
                    nextHour = 0;
                }

                result = TimeConvert(Format((60 - m))) + " minutes " + "to " + TimeConvert(Format(nextHour));

                if (m == 30)
                {
                    result = minutes + " past " + hour;
                }

                if (60 - m == 15)
                {
                    result = TimeConvert(Format(15)) + " to " + TimeConvert(Format(nextHour));
                }
            }

            return result;

        }

        static string TimeConvert(string t)
        {
            string time = "";
            switch (t)
            {
                case "00":
                    time = "zero";
                    break;
                case "01":
                    time = "one";
                    break;
                case "02":
                    time = "two";
                    break;
                case "03":
                    time = "three";
                    break;
                case "04":
                    time = "four";
                    break;
                case "05":
                    time = "five";
                    break;
                case "06":
                    time = "six";
                    break;
                case "07":
                    time = "seven";
                    break;
                case "08":
                    time = "eight";
                    break;
                case "09":
                    time = "nine";
                    break;
                case "10":
                    time = "ten";
                    break;
                case "11":
                    time = "eleven";
                    break;
                case "12":
                    time = "twelve";
                    break;
                case "13":
                    time = "thirteen";
                    break;
                case "14":
                    time = "fourteen";
                    break;
                case "15":
                    time = "quarter";
                    break;
                case "16":
                    time = "sixteen";
                    break;
                case "17":
                    time = "seventeen";
                    break;
                case "18":
                    time = "eighteen";
                    break;
                case "19":
                    time = "nineteen";
                    break;
                case "20":
                    time = "twenty";
                    break;
                case "21":
                    time = "twenty one";
                    break;
                case "22":
                    time = "twenty two";
                    break;
                case "23":
                    time = "twenty three";
                    break;
                case "24":
                    time = "twenty four";
                    break;
                case "25":
                    time = "twenty five";
                    break;
                case "26":
                    time = "twenty six";
                    break;
                case "27":
                    time = "twenty seven";
                    break;
                case "28":
                    time = "twenty eight";
                    break;
                case "29":
                    time = "twenty nine";
                    break;
                case "30":
                    time = "half";
                    break;
                default:
                    time = "Not a valid hour.";
                    break;
            }
            return time;
        }

        static string Format(int t)
        {
            string time = t.ToString();
            if (time.Length == 1)
            {
                time = "0" + time;
            }

            return time;
        }
    }
}
