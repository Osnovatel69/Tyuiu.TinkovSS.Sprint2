using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tiyiu.TinkovSS.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                x + 1 == y,
                x + y != y + x,
                x + y < y,
                x > y + 1,
                x + y <= y,
                x >= y + 1
            };
        }
    }
}