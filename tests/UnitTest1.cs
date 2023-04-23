namespace tests;
using generator;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        BiCharGen gen = new BiCharGen();
        for (int i = 0; i < 1000; i++)
            Assert.True(gen.getElement() != "юа");     
    }
    [Fact]
    public void Test2()
    {
        BiCharGen gen = new BiCharGen();
        for (int i = 0; i < 1000; i++)
            Assert.True(gen.getElement() != "бв");     
    }
    [Fact]
    public void Test3()
    {
        WordGen gen = new WordGen();
        int c1 = 0, c2 = 0;
        for (int i = 0; i < 1000; i++)
        {
            string s = gen.getElement();
            if (s == "здесь") c1++;
            if (s == "и") c2++;
        }
        Assert.True(c2>c1);     
    }
    [Fact]
    public void Test4()
    {
        WordGen gen = new WordGen();
        int c1 = 0, c2 = 0;
        for (int i = 0; i < 1000; i++)
        {
            string s = gen.getElement();
            if (s == "которые") c1++;
            if (s == "не") c2++;
        }
        Assert.True(c2>c1);     
    }
    [Fact]
    public void Test5()
    {
        BiWordGen gen = new BiWordGen();
        int c1 = 0, c2 = 0;
        for (int i = 0; i < 1000; i++)
        {
            string s = gen.getElement();
            if (s == "таким образом") c1++;
            if (s == "и не") c2++;
        }
        Assert.True(c2 > c1);     
    }
    [Fact]
    public void Test6()
    {
        BiWordGen gen = new BiWordGen();
        int c1 = 0, c2 = 0;
        for (int i = 0; i < 1000; i++)
        {
            string s = gen.getElement();
            if (s == "несмотря на") c1++;
            if (s == "потому что") c2++;
        }
        Assert.True(c2 > c1);     
    }
}
