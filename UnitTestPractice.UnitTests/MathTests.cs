using UnitTestPractice.Fundamentals;
namespace UnitTestPractice.UnitTests;

[TestFixture]
public class MathTests
{
    private MathT _math;

    [SetUp]
    public void SetUp()
    {
        this._math = new MathT();
    }
    [Test]
    public void Add_WhenCalled_ReturnTheSumOfArguments()
    {
        var result = _math.Add(2, 3);
        
        Assert.That(result, Is.EqualTo(5));
    }
    
    //We are going to write a generic parameterized test which will replace all three hard coded tests below
    
    [Test]
    [TestCase(2,1,2)]
    [TestCase(3,2,3)]
    [TestCase(1,1,1)]
    public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
    {
        var result = _math.Max(a, b);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    
    [Test]
    [Ignore("Wrote a generic parameterized test before")]
    public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
    {
        var result = _math.Max(3, 1);
        
        Assert.That(result, Is.EqualTo(3));
    }
    
    [Test]
    [Ignore("Wrote a generic parameterized test before")]
    public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
    {
        var result = _math.Max(1, 2);
        
        Assert.That(result, Is.EqualTo(2));
    }
    
    [Test]
    [Ignore("Wrote a generic parameterized test before")]
    public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
    {
        var result = _math.Max(2, 2);
        
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void GetOddNumbers_WhenLimitIsGreaterThanZero_ReturnOddNumbersUpToTheLimit()
    {
        var result = _math.GetOddNumbers(5);
        
        Assert.That(result, Is.EquivalentTo(new [] {1,3,5}));
        
        //more ways to test array elements
        // Assert.That(result, Is.Not.Empty);
        // Assert.That(result.Count(), Is.EqualTo(3));
        // Assert.That(result, Does.Contain(1));
    }
}