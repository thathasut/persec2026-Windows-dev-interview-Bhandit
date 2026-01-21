using NUnit.Framework;


[TestFixture]
public class DataSorterTests
{
    private DataSorter _sorter = new DataSorter();

    [Test]
    public void Test_SortWithMultipleCountries()
    {
        string[] input = { "TH19", "SG20", "TH2" };
        List<string> expected = new List<string> { "SG20", "TH2", "TH19" };

        Assert.That(_sorter.SortAlphanumeric(input), Is.EqualTo(expected));
    }

    [Test]
    public void Test_SortWithSamePrefixAndText()
    {
        string[] input = { "TH10", "TH3Netflix", "TH1", "TH7" };
        List<string> expected = new List<string> { "TH1", "TH3Netflix", "TH7", "TH10" };

        Assert.That(_sorter.SortAlphanumeric(input), Is.EqualTo(expected));
    }
}