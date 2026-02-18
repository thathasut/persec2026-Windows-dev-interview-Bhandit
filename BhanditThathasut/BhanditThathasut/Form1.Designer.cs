namespace BhanditThathasut
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblBracketResult = new Label();
            btnCheckBracket = new Button();
            txtBracketInput = new TextBox();
            lblBracketInput = new Label();
            tabPage2 = new TabPage();
            lblSortedResult = new Label();
            btnSortItems = new Button();
            txtSortInput = new TextBox();
            lblSortInput = new Label();
            tabPage3 = new TabPage();
            numMaxResult = new NumericUpDown();
            lstSuggestions = new ListBox();
            btnGetSuggestions = new Button();
            txtAutoCompleteItems = new TextBox();
            txtSearchTerm = new TextBox();
            lblMaxResLabel = new Label();
            lblItemsLabel = new Label();
            lblSearchLabel = new Label();
            tabPage4 = new TabPage();
            lblIntResult = new Label();
            lblRomanResult = new Label();
            btnConvertRomanToInt = new Button();
            btnConvertToIntToRoman = new Button();
            txtRomanToIntInput = new TextBox();
            txtIntToRomanInput = new TextBox();
            tabPage5 = new TabPage();
            lblSortedIntResult = new Label();
            btnSortIntDesc = new Button();
            txtIntToSortInput = new TextBox();
            lblIntSortLabel = new Label();
            tabPage6 = new TabPage();
            lblTriboResult = new Label();
            numTriboN = new NumericUpDown();
            btnGenerateTribo = new Button();
            txtTriboSignature = new TextBox();
            lblNLabel = new Label();
            lblSigLabel = new Label();

            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxResult).BeginInit();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTriboN).BeginInit();
            SuspendLayout();

            // tabControl1
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(21, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(767, 435);
            tabControl1.TabIndex = 0;

            // tabPage1 (Brackets)
            tabPage1.Controls.Add(lblBracketResult);
            tabPage1.Controls.Add(btnCheckBracket);
            tabPage1.Controls.Add(txtBracketInput);
            tabPage1.Controls.Add(lblBracketInput);
            tabPage1.Text = "1. Brackets";
            tabPage1.Size = new Size(759, 407);

            lblBracketResult.AutoSize = true;
            lblBracketResult.Font = new Font("Segoe UI", 12F);
            lblBracketResult.Location = new Point(83, 122);
            lblBracketResult.Text = "Result:";

            btnCheckBracket.Location = new Point(179, 79);
            btnCheckBracket.Size = new Size(120, 30);
            btnCheckBracket.Text = "Check Brackets";
            btnCheckBracket.Click += btnCheckBracket_Click; // เชื่อม Event

            txtBracketInput.Location = new Point(157, 29);
            txtBracketInput.Text = "()";

            // tabPage2 (Alphanumeric Sort)
            tabPage2.Controls.Add(lblSortedResult);
            tabPage2.Controls.Add(btnSortItems);
            tabPage2.Controls.Add(txtSortInput);
            tabPage2.Controls.Add(lblSortInput);
            tabPage2.Text = "2. Alphanumeric Sort";

            btnSortItems.Location = new Point(105, 108);
            btnSortItems.Size = new Size(120, 33);
            btnSortItems.Text = "Sort Items";
            btnSortItems.Click += btnSort_Click; // เชื่อม Event (ใช้ชื่อตาม Form1.cs)

            txtSortInput.Location = new Point(250, 39);
            txtSortInput.Size = new Size(200, 23);
            txtSortInput.Text = "TH19, SG20, TH2";

            // tabPage3 (Autocomplete)
            tabPage3.Controls.Add(numMaxResult);
            tabPage3.Controls.Add(lstSuggestions);
            tabPage3.Controls.Add(btnGetSuggestions);
            tabPage3.Controls.Add(txtAutoCompleteItems);
            tabPage3.Controls.Add(txtSearchTerm);
            tabPage3.Controls.Add(lblMaxResLabel);
            tabPage3.Controls.Add(lblItemsLabel);
            tabPage3.Controls.Add(lblSearchLabel);
            tabPage3.Text = "3. Autocomplete";

            btnGetSuggestions.Location = new Point(150, 150);
            btnGetSuggestions.Text = "Get Suggestions";
            btnGetSuggestions.Click += btnGetSuggestions_Click;

            txtSearchTerm.Location = new Point(150, 30);
            txtAutoCompleteItems.Location = new Point(150, 70);
            txtAutoCompleteItems.Size = new Size(300, 23);
            txtAutoCompleteItems.Text = "Mother, Think, Worthy, Apple, Android";
            numMaxResult.Location = new Point(150, 110);
            lstSuggestions.Location = new Point(150, 200);
            lstSuggestions.Size = new Size(200, 100);

            // tabPage4 (Roman Numerals)
            tabPage4.Controls.Add(lblIntResult);
            tabPage4.Controls.Add(lblRomanResult);
            tabPage4.Controls.Add(btnConvertRomanToInt);
            tabPage4.Controls.Add(btnConvertToIntToRoman);
            tabPage4.Controls.Add(txtRomanToIntInput);
            tabPage4.Controls.Add(txtIntToRomanInput);
            tabPage4.Text = "4. Roman Numerals";

            btnConvertToIntToRoman.Location = new Point(30, 70);
            btnConvertToIntToRoman.Text = "To Roman";
            btnConvertToIntToRoman.Click += btnConvertToIntToRoman_Click;

            btnConvertRomanToInt.Location = new Point(250, 70);
            btnConvertRomanToInt.Text = "To Integer";
            btnConvertRomanToInt.Click += btnConvertRomanToInt_Click;

            txtIntToRomanInput.Location = new Point(30, 30);
            txtRomanToIntInput.Location = new Point(250, 30);
            lblRomanResult.Location = new Point(30, 110);
            lblRomanResult.Text = "Roman: ";
            lblIntResult.Location = new Point(250, 110);
            lblIntResult.Text = "Integer: ";

            // tabPage5 (Sort Int Desc)
            tabPage5.Controls.Add(lblSortedIntResult);
            tabPage5.Controls.Add(btnSortIntDesc);
            tabPage5.Controls.Add(txtIntToSortInput);
            tabPage5.Controls.Add(lblIntSortLabel);
            tabPage5.Text = "5. Sort Int Desc";

            btnSortIntDesc.Location = new Point(150, 80);
            btnSortIntDesc.Text = "Sort Descending";
            btnSortIntDesc.Click += btnSortIntDesc_Click;
            txtIntToSortInput.Location = new Point(150, 30);
            lblSortedIntResult.Location = new Point(150, 130);
            lblSortedIntResult.Text = "Result: ";

            // tabPage6 (Tribonacci)
            tabPage6.Controls.Add(lblTriboResult);
            tabPage6.Controls.Add(numTriboN);
            tabPage6.Controls.Add(btnGenerateTribo);
            tabPage6.Controls.Add(txtTriboSignature);
            tabPage6.Text = "6. Tribonacci";

            btnGenerateTribo.Location = new Point(150, 120);
            btnGenerateTribo.Text = "Generate";
            btnGenerateTribo.Click += btnGenerateTribo_Click;
            txtTriboSignature.Location = new Point(150, 30);
            txtTriboSignature.Text = "1, 1, 1";
            numTriboN.Location = new Point(150, 70);
            lblTriboResult.Location = new Point(150, 170);
            lblTriboResult.Text = "Sequence: ";

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Algorithm Showcase - Bhandit";

            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxResult).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTriboN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1, tabPage2, tabPage3, tabPage4, tabPage5, tabPage6;

        // Task 1
        private Label lblBracketInput, lblBracketResult;
        private TextBox txtBracketInput;
        private Button btnCheckBracket;

        // Task 2
        private Label lblSortInput, lblSortedResult;
        private TextBox txtSortInput;
        private Button btnSortItems;

        // Task 3
        private Label lblSearchLabel, lblItemsLabel, lblMaxResLabel;
        private TextBox txtSearchTerm, txtAutoCompleteItems;
        private NumericUpDown numMaxResult;
        private ListBox lstSuggestions;
        private Button btnGetSuggestions;

        // Task 4
        private TextBox txtIntToRomanInput, txtRomanToIntInput;
        private Button btnConvertToIntToRoman, btnConvertRomanToInt;
        private Label lblRomanResult, lblIntResult;

        // Task 5
        private Label lblIntSortLabel, lblSortedIntResult;
        private TextBox txtIntToSortInput;
        private Button btnSortIntDesc;

        // Task 6
        private Label lblSigLabel, lblNLabel, lblTriboResult;
        private TextBox txtTriboSignature;
        private NumericUpDown numTriboN;
        private Button btnGenerateTribo;
    }
}