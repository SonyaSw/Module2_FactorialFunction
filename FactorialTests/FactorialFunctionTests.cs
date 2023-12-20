using FactorialFunction;

namespace FactorialTests;

[TestClass]
public class FactorialFunctionTests
{
    [TestMethod]
    ///Тестування прорахунку для чисел менше 0
    public void TestLessZero() => Assert.AreEqual(0, FactorialCalculator.ExecuteOperation(-1));

    [TestMethod]
    ///Тестування прорахунку для 0
    public void TestZero() => Assert.AreEqual(1, FactorialCalculator.ExecuteOperation(0));

    [TestMethod]
    ///Тестування прорахунку для чисел, більше за 0
    public void TestGreaterZero() => Assert.AreEqual(5040, FactorialCalculator.ExecuteOperation(7));
}