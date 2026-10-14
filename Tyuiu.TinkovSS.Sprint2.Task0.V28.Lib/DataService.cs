using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.YourSurnameII.Sprint2.Task0.V28.Lib
{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
            {
                x == y,
                x != y - 624,
                x + y < y,
                x > y,
                x + y <= y,
                x >= y
            };
        }
    }
}