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
            // 
            // tabControl1
            // 
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
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblBracketResult);
            tabPage1.Controls.Add(btnCheckBracket);
            tabPage1.Controls.Add(txtBracketInput);
            tabPage1.Controls.Add(lblBracketInput);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(759, 407);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1. Brackets";
            // 
            // lblBracketResult
            // 
            lblBracketResult.AutoSize = true;
            lblBracketResult.Font = new Font("Segoe UI", 12F);
            lblBracketResult.Location = new Point(83, 122);
            lblBracketResult.Name = "lblBracketResult";
            lblBracketResult.Size = new Size(56, 21);
            lblBracketResult.TabIndex = 0;
            lblBracketResult.Text = "Result:";
            // 
            // btnCheckBracket
            // 
            btnCheckBracket.Location = new Point(179, 79);
            btnCheckBracket.Name = "btnCheckBracket";
            btnCheckBracket.Size = new Size(120, 30);
            btnCheckBracket.TabIndex = 1;
            btnCheckBracket.Text = "Check Brackets";
            btnCheckBracket.Click += btnCheckBracket_Click;
            // 
            // txtBracketInput
            // 
            txtBracketInput.Location = new Point(157, 29);
            txtBracketInput.Name = "txtBracketInput";
            txtBracketInput.Size = new Size(100, 23);
            txtBracketInput.TabIndex = 2;
            txtBracketInput.Text = "()";
            // 
            // lblBracketInput
            // 
            lblBracketInput.Location = new Point(0, 0);
            lblBracketInput.Name = "lblBracketInput";
            lblBracketInput.Size = new Size(100, 23);
            lblBracketInput.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lblSortedResult);
            tabPage2.Controls.Add(btnSortItems);
            tabPage2.Controls.Add(txtSortInput);
            tabPage2.Controls.Add(lblSortInput);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(759, 407);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2. Alphanumeric Sort";
            // 
            // lblSortedResult
            // 
            lblSortedResult.AutoSize = true;
            lblSortedResult.Location = new Point(0, 0);
            lblSortedResult.Name = "lblSortedResult";
            lblSortedResult.Size = new Size(0, 15);
            lblSortedResult.TabIndex = 0;
            // 
            // btnSortItems
            // 
            btnSortItems.Location = new Point(105, 108);
            btnSortItems.Name = "btnSortItems";
            btnSortItems.Size = new Size(120, 33);
            btnSortItems.TabIndex = 1;
            btnSortItems.Text = "Sort Items";
            btnSortItems.Click += btnSort_Click;
            // 
            // txtSortInput
            // 
            txtSortInput.Location = new Point(250, 39);
            txtSortInput.Name = "txtSortInput";
            txtSortInput.Size = new Size(200, 23);
            txtSortInput.TabIndex = 2;
            txtSortInput.Text = "TH19, SG20, TH2";
            // 
            // lblSortInput
            // 
            lblSortInput.Location = new Point(0, 0);
            lblSortInput.Name = "lblSortInput";
            lblSortInput.Size = new Size(100, 23);
            lblSortInput.TabIndex = 3;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(numMaxResult);
            tabPage3.Controls.Add(lstSuggestions);
            tabPage3.Controls.Add(btnGetSuggestions);
            tabPage3.Controls.Add(txtAutoCompleteItems);
            tabPage3.Controls.Add(txtSearchTerm);
            tabPage3.Controls.Add(lblMaxResLabel);
            tabPage3.Controls.Add(lblItemsLabel);
            tabPage3.Controls.Add(lblSearchLabel);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(759, 407);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3. Autocomplete";
            // 
            // numMaxResult
            // 
            numMaxResult.Location = new Point(150, 110);
            numMaxResult.Name = "numMaxResult";
            numMaxResult.Size = new Size(120, 23);
            numMaxResult.TabIndex = 0;
            // 
            // lstSuggestions
            // 
            lstSuggestions.ItemHeight = 15;
            lstSuggestions.Location = new Point(150, 200);
            lstSuggestions.Name = "lstSuggestions";
            lstSuggestions.Size = new Size(200, 94);
            lstSuggestions.TabIndex = 1;
            // 
            // btnGetSuggestions
            // 
            btnGetSuggestions.Location = new Point(150, 150);
            btnGetSuggestions.Name = "btnGetSuggestions";
            btnGetSuggestions.Size = new Size(75, 23);
            btnGetSuggestions.TabIndex = 2;
            btnGetSuggestions.Text = "Get Suggestions";
            btnGetSuggestions.Click += btnGetSuggestions_Click;
            // 
            // txtAutoCompleteItems
            // 
            txtAutoCompleteItems.Location = new Point(150, 70);
            txtAutoCompleteItems.Name = "txtAutoCompleteItems";
            txtAutoCompleteItems.Size = new Size(300, 23);
            txtAutoCompleteItems.TabIndex = 3;
            txtAutoCompleteItems.Text = "Mother, Think, Worthy, Apple, Android";
            // 
            // txtSearchTerm
            // 
            txtSearchTerm.Location = new Point(150, 30);
            txtSearchTerm.Name = "txtSearchTerm";
            txtSearchTerm.Size = new Size(100, 23);
            txtSearchTerm.TabIndex = 4;
            // 
            // lblMaxResLabel
            // 
            lblMaxResLabel.Location = new Point(0, 0);
            lblMaxResLabel.Name = "lblMaxResLabel";
            lblMaxResLabel.Size = new Size(100, 23);
            lblMaxResLabel.TabIndex = 5;
            // 
            // lblItemsLabel
            // 
            lblItemsLabel.Location = new Point(0, 0);
            lblItemsLabel.Name = "lblItemsLabel";
            lblItemsLabel.Size = new Size(100, 23);
            lblItemsLabel.TabIndex = 6;
            // 
            // lblSearchLabel
            // 
            lblSearchLabel.Location = new Point(0, 0);
            lblSearchLabel.Name = "lblSearchLabel";
            lblSearchLabel.Size = new Size(100, 23);
            lblSearchLabel.TabIndex = 7;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(lblIntResult);
            tabPage4.Controls.Add(lblRomanResult);
            tabPage4.Controls.Add(btnConvertRomanToInt);
            tabPage4.Controls.Add(btnConvertToIntToRoman);
            tabPage4.Controls.Add(txtRomanToIntInput);
            tabPage4.Controls.Add(txtIntToRomanInput);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(759, 407);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "4. Roman Numerals";
            // 
            // lblIntResult
            // 
            lblIntResult.AutoSize = true;
            lblIntResult.Location = new Point(250, 110);
            lblIntResult.Name = "lblIntResult";
            lblIntResult.Size = new Size(50, 15);
            lblIntResult.TabIndex = 0;
            lblIntResult.Text = "Integer: ";
            // 
            // lblRomanResult
            // 
            lblRomanResult.AutoSize = true;
            lblRomanResult.Location = new Point(30, 110);
            lblRomanResult.Name = "lblRomanResult";
            lblRomanResult.Size = new Size(51, 15);
            lblRomanResult.TabIndex = 1;
            lblRomanResult.Text = "Roman: ";
            // 
            // btnConvertRomanToInt
            // 
            btnConvertRomanToInt.Location = new Point(250, 70);
            btnConvertRomanToInt.Name = "btnConvertRomanToInt";
            btnConvertRomanToInt.Size = new Size(75, 23);
            btnConvertRomanToInt.TabIndex = 2;
            btnConvertRomanToInt.Text = "To Integer";
            btnConvertRomanToInt.Click += btnConvertRomanToInt_Click;
            // 
            // btnConvertToIntToRoman
            // 
            btnConvertToIntToRoman.Location = new Point(30, 70);
            btnConvertToIntToRoman.Name = "btnConvertToIntToRoman";
            btnConvertToIntToRoman.Size = new Size(75, 23);
            btnConvertToIntToRoman.TabIndex = 3;
            btnConvertToIntToRoman.Text = "To Roman";
            btnConvertToIntToRoman.Click += btnConvertToIntToRoman_Click;
            // 
            // txtRomanToIntInput
            // 
            txtRomanToIntInput.Location = new Point(250, 30);
            txtRomanToIntInput.Name = "txtRomanToIntInput";
            txtRomanToIntInput.Size = new Size(100, 23);
            txtRomanToIntInput.TabIndex = 4;
            // 
            // txtIntToRomanInput
            // 
            txtIntToRomanInput.Location = new Point(30, 30);
            txtIntToRomanInput.Name = "txtIntToRomanInput";
            txtIntToRomanInput.Size = new Size(100, 23);
            txtIntToRomanInput.TabIndex = 5;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(lblSortedIntResult);
            tabPage5.Controls.Add(btnSortIntDesc);
            tabPage5.Controls.Add(txtIntToSortInput);
            tabPage5.Controls.Add(lblIntSortLabel);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(759, 407);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "5. Sort Int Desc";
            // 
            // lblSortedIntResult
            // 
            lblSortedIntResult.Location = new Point(150, 130);
            lblSortedIntResult.Name = "lblSortedIntResult";
            lblSortedIntResult.Size = new Size(100, 23);
            lblSortedIntResult.TabIndex = 0;
            lblSortedIntResult.Text = "Result: ";
            // 
            // btnSortIntDesc
            // 
            btnSortIntDesc.Location = new Point(150, 80);
            btnSortIntDesc.Name = "btnSortIntDesc";
            btnSortIntDesc.Size = new Size(75, 23);
            btnSortIntDesc.TabIndex = 1;
            btnSortIntDesc.Text = "Sort Descending";
            btnSortIntDesc.Click += btnSortIntDesc_Click;
            // 
            // txtIntToSortInput
            // 
            txtIntToSortInput.Location = new Point(150, 30);
            txtIntToSortInput.Name = "txtIntToSortInput";
            txtIntToSortInput.Size = new Size(100, 23);
            txtIntToSortInput.TabIndex = 2;
            // 
            // lblIntSortLabel
            // 
            lblIntSortLabel.Location = new Point(0, 0);
            lblIntSortLabel.Name = "lblIntSortLabel";
            lblIntSortLabel.Size = new Size(100, 23);
            lblIntSortLabel.TabIndex = 3;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(lblTriboResult);
            tabPage6.Controls.Add(numTriboN);
            tabPage6.Controls.Add(btnGenerateTribo);
            tabPage6.Controls.Add(txtTriboSignature);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(759, 407);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "6. Tribonacci";
            // 
            // lblTriboResult
            // 
            lblTriboResult.AutoSize = true;
            lblTriboResult.Location = new Point(150, 170);
            lblTriboResult.Name = "lblTriboResult";
            lblTriboResult.Size = new Size(64, 15);
            lblTriboResult.TabIndex = 0;
            lblTriboResult.Text = "Sequence: ";
            // 
            // numTriboN
            // 
            numTriboN.Location = new Point(150, 70);
            numTriboN.Name = "numTriboN";
            numTriboN.Size = new Size(120, 23);
            numTriboN.TabIndex = 1;
            // 
            // btnGenerateTribo
            // 
            btnGenerateTribo.Location = new Point(150, 120);
            btnGenerateTribo.Name = "btnGenerateTribo";
            btnGenerateTribo.Size = new Size(75, 23);
            btnGenerateTribo.TabIndex = 2;
            btnGenerateTribo.Text = "Generate";
            btnGenerateTribo.Click += btnGenerateTribo_Click;
            // 
            // txtTriboSignature
            // 
            txtTriboSignature.Location = new Point(150, 30);
            txtTriboSignature.Name = "txtTriboSignature";
            txtTriboSignature.Size = new Size(100, 23);
            txtTriboSignature.TabIndex = 3;
            txtTriboSignature.Text = "1, 1, 1";
            // 
            // lblNLabel
            // 
            lblNLabel.Location = new Point(0, 0);
            lblNLabel.Name = "lblNLabel";
            lblNLabel.Size = new Size(100, 23);
            lblNLabel.TabIndex = 0;
            // 
            // lblSigLabel
            // 
            lblSigLabel.Location = new Point(0, 0);
            lblSigLabel.Name = "lblSigLabel";
            lblSigLabel.Size = new Size(100, 23);
            lblSigLabel.TabIndex = 0;
            // 
            // Form1
            // 
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