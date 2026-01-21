
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        var app = new BracketValidate();

        // --- ส่วนที่ 1: ตรวจสอบวงเล็บ ---
        string[] bracketInputs = { "()", "([]]", "([{}])", "([[{}]]]", ")", "([)]" };
        Console.WriteLine("--- 1. Bracket Validation Results ---");

        foreach (var input in bracketInputs)
        {
            bool result = app.IsValid(input);
            Console.ForegroundColor = result ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine($"Input: {input,-12} | Result: {result}");
        }
        Console.ResetColor();

        // --- ส่วนที่ 2: การเรียงลำดับ ---
        Console.WriteLine("\n--- 2. Alphanumeric Sorting Results ---");

        string[] data1 = { "TH19", "SG20", "TH2" };
        string[] data2 = { "TH10", "TH3Netflix", "TH1", "TH7" };

        var result1 = app.SortAlphanumeric(data1);
        var result2 = app.SortAlphanumeric(data2);

        Console.WriteLine("Set 1: " + string.Join(", ", result1));
        Console.WriteLine("Set 2: " + string.Join(", ", result2));


        // --- ส่วนที่ 3: Autocomplete ---
        Console.WriteLine("=== Task 3: Autocomplete Results ===");

        string search = "th";
        string[] items = { "Mother", "Think", "Worthy", "Apple", "Android" };
        int maxResult = 2;

        List<string> autoResults = app.Autocomplete(search, items, maxResult);

        Console.WriteLine($"Search: '{search}' | MaxResult: {maxResult}");
        Console.WriteLine("Items: [" + string.Join(", ", items) + "]");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Result: [" + string.Join(", ", autoResults) + "]");
        Console.ResetColor();

        // --- ส่วนที่ 4: Roman Numerals ---
        Console.WriteLine("=== Task 4: Roman Numerals ===");

        int[] numbers = { 1989, 2000, 68, 109 };
        foreach (int n in numbers)
        {
            Console.WriteLine($"{n} => {app.ToRoman(n)}");
        }

      
        string[] romans = { "MCMLXXXIX", "MM", "LXVIII", "CIX" };
        foreach (string r in romans)
        {
            Console.WriteLine($"{r} => {app.FromRoman(r)}");
        }
        // --- ส่วนที่ 5: Sort Positive Int Descending ---
        Console.WriteLine("\n=== Task 5: Sort Int Descending Results ===");

        int[] testInts = { 3008, 1989, 2679, 9163 };

        foreach (int n in testInts)
        {
            int result = app.SortIntDescending(n);
            Console.WriteLine($"Input: {n,-6} => Output: {result}");
        }
        // --- ส่วนที่ 6: Tribonacci Sequence ---
        Console.WriteLine("\n=== Task 6: Tribonacci Results ===");

        // Case 1: f([1, 3, 5], 5)
        PrintTribo(app.Tribonacci(new[] { 1, 3, 5 }, 5));

        // Case 2: f([2, 2, 2], 3)
        PrintTribo(app.Tribonacci(new[] { 2, 2, 2 }, 3));

        // Case 3: f([10, 10, 10], 4)
        PrintTribo(app.Tribonacci(new[] { 10, 10, 10 }, 4));

        // Case 4: กรณี signature ไม่ครบ 3 ตัว เช่น [1] และต้องการ 5 ตัว
        PrintTribo(app.Tribonacci(new[] { 0, 0, 1 }, 7));
        Console.WriteLine("\n--- All Tasks Completed ---");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
    static void PrintTribo(List<int> res)
    {
        Console.WriteLine("[" + string.Join(", ", res) + "]");
    }
}