namespace DiceRoller
{
    partial class Roller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DiceTypeSelection = new ComboBox();
            ModifierBox = new NumericUpDown();
            Rolls = new NumericUpDown();
            CalculateRoll = new Button();
            label1 = new Label();
            label2 = new Label();
            RollCalcTextBox = new TextBox();
            TotalRollBox = new TextBox();
            label4 = new Label();
            ArrayResultsBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ModifierBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Rolls).BeginInit();
            SuspendLayout();
            // 
            // DiceTypeSelection
            // 
            DiceTypeSelection.FormattingEnabled = true;
            DiceTypeSelection.Items.AddRange(new object[] { "D20", "D12", "D10", "D100", "D8", "D6", "D4" });
            DiceTypeSelection.Location = new Point(22, 31);
            DiceTypeSelection.Name = "DiceTypeSelection";
            DiceTypeSelection.Size = new Size(63, 23);
            DiceTypeSelection.TabIndex = 9;
            // 
            // ModifierBox
            // 
            ModifierBox.Location = new Point(160, 31);
            ModifierBox.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            ModifierBox.Name = "ModifierBox";
            ModifierBox.Size = new Size(53, 23);
            ModifierBox.TabIndex = 8;
            // 
            // Rolls
            // 
            Rolls.Location = new Point(96, 31);
            Rolls.Name = "Rolls";
            Rolls.Size = new Size(58, 23);
            Rolls.TabIndex = 7;
            // 
            // CalculateRoll
            // 
            CalculateRoll.Location = new Point(219, 31);
            CalculateRoll.Name = "CalculateRoll";
            CalculateRoll.Size = new Size(48, 23);
            CalculateRoll.TabIndex = 5;
            CalculateRoll.Text = "Roll";
            CalculateRoll.UseVisualStyleBackColor = true;
            CalculateRoll.Click += CalculateRoll_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 13);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 10;
            label1.Text = "Amount";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 13);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 11;
            label2.Text = "Modifier";
            // 
            // RollCalcTextBox
            // 
            RollCalcTextBox.Location = new Point(273, 31);
            RollCalcTextBox.Name = "RollCalcTextBox";
            RollCalcTextBox.Size = new Size(71, 23);
            RollCalcTextBox.TabIndex = 12;
            // 
            // TotalRollBox
            // 
            TotalRollBox.Location = new Point(350, 31);
            TotalRollBox.Name = "TotalRollBox";
            TotalRollBox.Size = new Size(55, 23);
            TotalRollBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(350, 13);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 15;
            label4.Text = "Total Roll";
            // 
            // ArrayResultsBox
            // 
            ArrayResultsBox.Location = new Point(22, 76);
            ArrayResultsBox.Name = "ArrayResultsBox";
            ArrayResultsBox.ScrollBars = ScrollBars.Horizontal;
            ArrayResultsBox.Size = new Size(383, 23);
            ArrayResultsBox.TabIndex = 16;
            ArrayResultsBox.WordWrap = false;
            // 
            // Roller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 117);
            Controls.Add(ArrayResultsBox);
            Controls.Add(label4);
            Controls.Add(TotalRollBox);
            Controls.Add(RollCalcTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DiceTypeSelection);
            Controls.Add(ModifierBox);
            Controls.Add(Rolls);
            Controls.Add(CalculateRoll);
            Name = "Roller";
            Text = "Roller";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ModifierBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Rolls).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox DiceTypeSelection;
        private NumericUpDown ModifierBox;
        private NumericUpDown Rolls;
        private Button CalculateRoll;
        private Label label1;
        private Label label2;
        private TextBox RollCalcTextBox;
        private TextBox TotalRollBox;
        private Label label4;
        private TextBox ArrayResultsBox;
    }
}