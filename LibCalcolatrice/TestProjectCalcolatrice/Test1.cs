namespace TestProjectCalcolatrice;
using LibCalcolatrice;
using Microsoft.VisualStudio.TestTools.UnitTesting;


[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestSomma()
    {
        var calc = new Calcolatrice();
        var risultato = calc.somma(3, 5);
        Assert.Equals(8, risultato);
    }

    [TestMethod]
    public void TestSommaZero()
    {
        var calc = new Calcolatrice();
        var risultato = calc.somma(3, 0);
        Assert.AreEqual(3, risultato);
    }

    [TestMethod]
    public void TestSommaRelativo()
    {
        var calc = new Calcolatrice();
        var risultato = calc.somma(3, -1);
        Assert.AreEqual(2, risultato);
    }

}
