using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task5.V13.Lib
{
    public class DataService : ISprint2Task5V13
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            if (m < 1 || m > 12 || n < 1 || n > 31)
        {
                return "Некорректная дата";
            }

            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (IsLeapYear(g))
            {
                daysInMonth[2] = 29;
            }

            if (n < daysInMonth[m])
            {
                n++;
            }
            else
            {
                n = 1;
                if (m == 12)
                {
                    m = 1;
                    g++;
                }
                else
                {
                    m++;
                }
            }

            return $"{n}.{m}.{g}";
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
