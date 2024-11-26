using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KonstantinovaJN.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= -x && y <= x) && x + y <= 1)
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
