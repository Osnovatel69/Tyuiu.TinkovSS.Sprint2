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
            // Подготовка исходных данных.
            int x = 111;
            int y = 735;

            DataService dataService = new DataService();

            bool[] expected = new bool[]
            {
                false,
                false,
                false,
                false,
                false,
                false
            };

            // Вызов метода библиотеки.
            bool[] actual = dataService.GetCompareOperations(x, y);

            // Проверка длины массива, значений и порядка элементов.
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}