using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task2.V12.Lib
{
    public class DataService : ISprint2Task2V12
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((1 <= x && x <= 5 && 3 <= y && y <= 6) ||
                (4 <= x && x <= 10 && 6 <= y && y <= 10) ||
                (6 <= x && x <= 11 && 4 <= y && y <= 6) ||
                (9 <= x && x <= 12 && 3 <= y && y <= 4) ||
                (11 <= x && x <= 12 && 5 <= y && y <= 7) ||
                (10 <= x && x <= 11 && 10 <= y && y <= 11) ||
                (9 <= x && x <= 10 && 11 <= y && y <= 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
