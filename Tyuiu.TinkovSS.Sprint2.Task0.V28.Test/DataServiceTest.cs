using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TinkovSS.Sprint2.Task0.V28.Lib;

namespace Tyuiu.TinkovSS.Sprint2.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetCompareOperations_Variant28_ReturnsSixFalseValues()
        {
            // Подготовка исходных данных.
            DataService dataService = new DataService();

            int x = 111;
            int y = 735;

            bool[] expected = new bool[]
            {
                false,
                false,
                false,
                false,
                false,
                false
            };

            // Выполнение метода библиотеки.
            bool[] actual = dataService.GetCompareOperations(x, y);

            // Проверка результата, длины массива и порядка элементов.
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetCompareOperations_EqualInputs_UsesPassedArguments()
        {
            // Дополнительная проверка:
            // метод должен вычислять результат из аргументов,
            // а не всегда возвращать шесть значений false.
            DataService dataService = new DataService();

            int x = 10;
            int y = 10;

            bool[] expected = new bool[]
            {
                true,
                true,
                false,
                false,
                false,
                true
            };

            bool[] actual = dataService.GetCompareOperations(x, y);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
