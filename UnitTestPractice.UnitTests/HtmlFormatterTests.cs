using UnitTestPractice.Fundamentals;

namespace UnitTestPractice.UnitTests;

[TestFixture]
public class HtmlFormatterTests
{
    [Test]
    public void FormatAsBold_WhenCalled_ShouldReturnWithTheStringInTheParameter()
    {
        var formatter = new HtmlFormatter();

        var result = formatter.FormatAsBold("abc");
        
        //specific
        Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
        
        //more general
        Assert.That(result, Does.Contain("abc"));
        Assert.That(result, Does.StartWith("<strong>"));
        Assert.That(result, Does.EndWith("</strong>"));
    }
}