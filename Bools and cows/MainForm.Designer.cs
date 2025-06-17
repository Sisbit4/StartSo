
namespace BullsAndCowsGame
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDigitsLabel = new System.Windows.Forms.Label();
            this.numericUpDownDigits = new System.Windows.Forms.NumericUpDown();
            this.lblNumberLabel = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblGuessedDigitsLabel = new System.Windows.Forms.Label();
            this.lblGuessedDigits = new System.Windows.Forms.Label();
            this.lblCorrectPositionsLabel = new System.Windows.Forms.Label();
            this.lblCorrectPositions = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripAttempts = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTimeText = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(32, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Угадайте задуманное число";
            // 
            // lblDigitsLabel
            // 
            this.lblDigitsLabel.AutoSize = true;
            this.lblDigitsLabel.Location = new System.Drawing.Point(16, 55);
            this.lblDigitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDigitsLabel.Name = "lblDigitsLabel";
            this.lblDigitsLabel.Size = new System.Drawing.Size(100, 16);
            this.lblDigitsLabel.TabIndex = 1;
            this.lblDigitsLabel.Text = "Число знаков:";
            // 
            // numericUpDownDigits
            // 
            this.numericUpDownDigits.Location = new System.Drawing.Point(135, 53);
            this.numericUpDownDigits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownDigits.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownDigits.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownDigits.Name = "numericUpDownDigits";
            this.numericUpDownDigits.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownDigits.TabIndex = 2;
            this.numericUpDownDigits.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblNumberLabel
            // 
            this.lblNumberLabel.AutoSize = true;
            this.lblNumberLabel.Location = new System.Drawing.Point(16, 92);
            this.lblNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberLabel.Name = "lblNumberLabel";
            this.lblNumberLabel.Size = new System.Drawing.Size(50, 16);
            this.lblNumberLabel.TabIndex = 3;
            this.lblNumberLabel.Text = "Число:";
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(135, 89);
            this.txtGuess.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuess.MaxLength = 6;
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(132, 22);
            this.txtGuess.TabIndex = 4;
            this.txtGuess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGuess_KeyDown);
            this.txtGuess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGuess_KeyPress);
            // 
            // lblGuessedDigitsLabel
            // 
            this.lblGuessedDigitsLabel.AutoSize = true;
            this.lblGuessedDigitsLabel.Location = new System.Drawing.Point(16, 129);
            this.lblGuessedDigitsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuessedDigitsLabel.Name = "lblGuessedDigitsLabel";
            this.lblGuessedDigitsLabel.Size = new System.Drawing.Size(103, 16);
            this.lblGuessedDigitsLabel.TabIndex = 5;
            this.lblGuessedDigitsLabel.Text = "Угадано цифр:";
            // 
            // lblGuessedDigits
            // 
            this.lblGuessedDigits.AutoSize = true;
            this.lblGuessedDigits.Location = new System.Drawing.Point(143, 129);
            this.lblGuessedDigits.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuessedDigits.Name = "lblGuessedDigits";
            this.lblGuessedDigits.Size = new System.Drawing.Size(0, 16);
            this.lblGuessedDigits.TabIndex = 6;
            // 
            // lblCorrectPositionsLabel
            // 
            this.lblCorrectPositionsLabel.AutoSize = true;
            this.lblCorrectPositionsLabel.Location = new System.Drawing.Point(16, 166);
            this.lblCorrectPositionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrectPositionsLabel.Name = "lblCorrectPositionsLabel";
            this.lblCorrectPositionsLabel.Size = new System.Drawing.Size(160, 16);
            this.lblCorrectPositionsLabel.TabIndex = 7;
            this.lblCorrectPositionsLabel.Text = "Из них на своих местах:";
            // 
            // lblCorrectPositions
            // 
            this.lblCorrectPositions.AutoSize = true;
            this.lblCorrectPositions.Location = new System.Drawing.Point(249, 166);
            this.lblCorrectPositions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrectPositions.Name = "lblCorrectPositions";
            this.lblCorrectPositions.Size = new System.Drawing.Size(0, 16);
            this.lblCorrectPositions.TabIndex = 8;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(20, 209);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(128, 209);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 28);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(236, 209);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAttempts,
            this.toolStripTimeText});
            this.statusStrip.Location = new System.Drawing.Point(0, 257);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(352, 26);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripAttempts
            // 
            this.toolStripAttempts.Name = "toolStripAttempts";
            this.toolStripAttempts.Size = new System.Drawing.Size(86, 20);
            this.toolStripAttempts.Text = "Попыток: 0";
            // 
            // toolStripTimeText
            // 
            this.toolStripTimeText.Name = "toolStripTimeText";
            this.toolStripTimeText.Size = new System.Drawing.Size(246, 20);
            this.toolStripTimeText.Spring = true;
            this.toolStripTimeText.Text = "Затрачено времени: 0";
            this.toolStripTimeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(20, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(324, 15);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Цифры в загаданном числе не могут повторятся,";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 283);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblCorrectPositions);
            this.Controls.Add(this.lblCorrectPositionsLabel);
            this.Controls.Add(this.lblGuessedDigits);
            this.Controls.Add(this.lblGuessedDigitsLabel);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblNumberLabel);
            this.Controls.Add(this.numericUpDownDigits);
            this.Controls.Add(this.lblDigitsLabel);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Быки и коровы";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDigitsLabel;
        private System.Windows.Forms.NumericUpDown numericUpDownDigits;
        private System.Windows.Forms.Label lblNumberLabel;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblGuessedDigitsLabel;
        private System.Windows.Forms.Label lblGuessedDigits;
        private System.Windows.Forms.Label lblCorrectPositionsLabel;
        private System.Windows.Forms.Label lblCorrectPositions;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAttempts;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTimeText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox1;
    }
}
