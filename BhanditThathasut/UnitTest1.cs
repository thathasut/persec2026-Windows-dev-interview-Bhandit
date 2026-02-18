using NUnit.Framework;
using BhanditThathasut; 
using System.Collections.Generic;

namespace TestBhandit
{
    public class Tests
    {
        [SetUp]
        public void Setup() { }

        // --- 1. Test สำหรับตรวจสอบวงเล็บ ---
        [TestFixture]
        public class BracketTests
        {
            private readonly BracketValidator _validator = new BracketValidator();

            [TestCase("()", ExpectedResult = true)]
            [TestCase("([{}])", ExpectedResult = true)]
            [TestCase("([]]", ExpectedResult = false)]
            [TestCase("([)]", ExpectedResult = false)]
            [TestCase(")", ExpectedResult = false)]
            public bool Test_IsValid(string input) => _validator.IsValid(input);
        }

        // --- 2. Test สำหรับเรียงลำดับ Alphanumeric ---
        [TestFixture]
        public class SortingTests
        {
            private readonly AlphanumericSorter _sorter = new AlphanumericSorter();

            [Test]
            public void Test_AlphanumericSort()
            {
                string[] input = { "TH19", "SG20", "TH2" };
                var result = _sorter.SortData(input);
                Assert.That(result, Is.EqualTo(new List<string> { "SG20", "TH2", "TH19" }));
            }
        }

        // --- 3. Test สำหรับ Autocomplete ---
        [TestFixture]
        public class AutocompleteTests
        {
            private readonly AutocompleteEngine _engine = new AutocompleteEngine();

            [Test]
            public void Test_AutocompleteRanking()
            {
                string[] items = { "Mother", "Think", "Worthy" };
                var result = _engine.Search("th", items, 2);
                Assert.That(result, Is.EqualTo(new List<string> { "Think", "Mother" }));
            }
        }

        // --- 4. Test สำหรับเลขโรมัน ---
        [TestFixture]
        public class RomanTests
        {
            private readonly RomanConverter _converter = new RomanConverter();

            [TestCase(1989, ExpectedResult = "MCMLXXXIX")]
            [TestCase(4, ExpectedResult = "IV")]
            public string Test_ToRoman(int n) => _converter.ToRoman(n);

            [TestCase("CIX", ExpectedResult = 109)]
            public int Test_FromRoman(string r) => _converter.FromRoman(r);
        }

        // --- 5. Test สำหรับเรียงเลขจากมากไปน้อย ---
        [TestFixture]
        public class NumberSortTests
        {
            private readonly NumberDescendingSorter _sorter = new NumberDescendingSorter();

            [TestCase(3008, ExpectedResult = 8300)]
            [TestCase(1989, ExpectedResult = 9981)]
            public int Test_SortInt(int n) => _sorter.SortInt(n);
        }

        // --- 6. Test สำหรับ Tribonacci ---
        [TestFixture]
        public class TribonacciTests
        {
            private readonly TribonacciCalculator _calc = new TribonacciCalculator();

            [Test]
            public void Test_TribonacciSequence()
            {
                int[] signature = { 1, 3, 5 };
                var result = _calc.GetSequence(signature, 5);
                Assert.That(result, Is.EqualTo(new List<int> { 1, 3, 5, 9, 17 }));
            }
        }
    }
}