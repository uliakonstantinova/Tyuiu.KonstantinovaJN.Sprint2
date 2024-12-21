﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int daysInMonth;

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                case 2:
                    daysInMonth = 29;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Неверный номер месяца.");
            }

            if (n < 1 || n > daysInMonth)
            {
                throw new ArgumentOutOfRangeException("Неверный день месяца.");
            }

            n++;

            if (n > daysInMonth)
            {
                n = 1;
                m++;

                if (m > 12)
                {
                    m = 1;
                    g++;
                }
            }
            return $"{g:D4}-{m:D2}-{n:D2}";
        }
    }
}
