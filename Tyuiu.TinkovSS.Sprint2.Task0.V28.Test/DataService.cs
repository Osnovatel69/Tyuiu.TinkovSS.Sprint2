using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_ReturnsSixFalseValues()
        {
            // Исходные данные.
            int x = 111;
            int y = 735;

            DataService ds = new DataService();

            bool[] expected = new bool[]
            {
                false,
                false,
                false,
                false,
                false,
                false
            };

            // Выполнение.
            bool[] actual = ds.GetCompareOperations(x, y);

            // Проверка всего массива и порядка элементов.
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}