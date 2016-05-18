using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeechTimer
{
    class TimeObj
    {
        private int second=0;
        private int minute=0;
        private int hour=0;
        private int sign = 1;

        public TimeObj(int S = 0,int M = 0, int H = 0)
        {
            second = S;
            minute = M;
            hour = H;
            Standardize();
        }

        public void SetTime(int S = 0, int M = 0, int H = 0)
        {
            second = S;
            minute = M;
            hour = H;
            Standardize();
        }

        public void AdjustTime(int S=0,int M=0,int H = 0)
        {
            second += S;
            minute += M;
            hour += H;
            Standardize();
        }

        public string GetTimeStr(int str_format = 0)
        {
            string result = "";
            switch(str_format)
            {
                case 0:
                    if (hour > 0) { result = hour.ToString() + ":"; }
                    if (minute > 0 && hour == 0) { result += (minute.ToString() + ":"); }
                    if (hour > 0){ result += (minute.ToString().PadLeft(2, '0') + ":"); }
                    result += minute.ToString();
                    break;
                case 1:
                    result = (second + minute * 60 + hour * 3600).ToString();
                    break;
                case 2:
                    result = (hour * 60 + minute).ToString() + ":" + second.ToString().PadLeft(2, '0');
                    break;
                case 3:
                    result = hour.ToString() + ":" + minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0');
                    break;
            }
            if (sign != 1) { result = "-" + result; }
            return result;
        }

        private void Standardize()
        {
            if (minute < 0 || second < 0 || hour < 0)
            {
                sign = -1;
                minute = Math.Abs(minute);
                second = Math.Abs(second);
                hour = Math.Abs(hour);
            }
            else
            {
                sign = 1;
            }
            int total_sec = second + minute * 60 + hour * 3600;
            hour = total_sec / 3600;
            minute = (total_sec - hour * 3600) / 60;
            second = total_sec - minute * 60 - hour*3600;
        }
    }
}
