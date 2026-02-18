using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BhanditThathasut
{
    public partial class Form1 : Form
    {
        
        private BracketValidator _bracket = new BracketValidator();
        private AlphanumericSorter _sorter = new AlphanumericSorter();
        private AutocompleteEngine _auto = new AutocompleteEngine();
        private RomanConverter _roman = new RomanConverter();
        private NumberDescendingSorter _numSort = new NumberDescendingSorter();
        private TribonacciCalculator _tribo = new TribonacciCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        // --- Task 1: Bracket Validation ---
        private void btnCheckBracket_Click(object sender, EventArgs e)
        {
            string input = txtBracketInput.Text;
            bool isValid = _bracket.IsValid(input);

            lblBracketResult.Text = $"Result: {isValid}";
            lblBracketResult.ForeColor = isValid ? Color.Green : Color.Red;
        }

        // --- Task 2: Alphanumeric Sort ---
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSortInput.Text)) return;

            string[] items = txtSortInput.Text.Split(',')
                                             .Select(s => s.Trim())
                                             .Where(s => !string.IsNullOrEmpty(s))
                                             .ToArray();

            var result = _sorter.SortData(items);
            lblSortedResult.Text = "Sorted: " + string.Join(", ", result);
        }

        // --- Task 3: Autocomplete ---
        private void btnGetSuggestions_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchTerm.Text;
            string[] items = txtAutoCompleteItems.Text.Split(',')
                                                      .Select(s => s.Trim())
                                                      .ToArray();
            int max = (int)numMaxResult.Value;

            var suggestions = _auto.Search(searchTerm, items, max);

            lstSuggestions.Items.Clear();
            foreach (var item in suggestions)
            {
                lstSuggestions.Items.Add(item);
            }
        }

        // --- Task 4: Roman Numerals ---
        private void btnConvertToIntToRoman_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIntToRomanInput.Text, out int num))
            {
                lblRomanResult.Text = "Roman: " + _roman.ToRoman(num);
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnConvertRomanToInt_Click(object sender, EventArgs e)
        {
            try
            {
                string romanStr = txtRomanToIntInput.Text.ToUpper().Trim();
                int result = _roman.FromRoman(romanStr);
                lblIntResult.Text = "Integer: " + result.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Roman Numerals.");
            }
        }

        // --- Task 5: Sort Positive Int Descending ---
        private void btnSortIntDesc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtIntToSortInput.Text, out int num) && num >= 0)
            {
                int result = _numSort.SortInt(num);
                lblSortedIntResult.Text = "Result: " + result.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a positive integer.");
            }
        }

        // --- Task 6: Tribonacci Sequence ---
        private void btnGenerateTribo_Click(object sender, EventArgs e)
        {
            try
            {
                int[] signature = txtTriboSignature.Text.Split(',')
                                                        .Select(s => int.Parse(s.Trim()))
                                                        .ToArray();
                int n = (int)numTriboN.Value;

                var result = _tribo.GetSequence(signature, n);
                lblTriboResult.Text = "Sequence: " + string.Join(", ", result);
            }
            catch
            {
                MessageBox.Show("Please check signature format (e.g., 1, 1, 1).");
            }
        }
    }
}