using NUnit.Framework;
using ConsoleApp1; 

[TestFixture]
public class BracketValidateTests
{
    private BracketValidate? _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new BracketValidate();
    }

    [TestCase("()", ExpectedResult = true)]
    [TestCase("([]]", ExpectedResult = false)]
    [TestCase("([{}])", ExpectedResult = true)]
    [TestCase("([[{}]]]", ExpectedResult = false)]
    [TestCase(")", ExpectedResult = false)]
    [TestCase("(]}])", ExpectedResult = false)]
    [TestCase("([)]", ExpectedResult = false)]
    public bool Test_BracketValidation_MultipleCases(string input)
    {
        return _validator.IsValid(input);
    }
}