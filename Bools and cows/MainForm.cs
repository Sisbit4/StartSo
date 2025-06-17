
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace BullsAndCowsGame
{
    public partial class MainForm : Form
    {
        private string secretNumber;
        private int attempts;
        private readonly Stopwatch stopwatch = new Stopwatch();
        private int digitsCount;

        public MainForm()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            digitsCount = (int)numericUpDownDigits.Value;
            btnStart.Enabled = true;
            btnReset.Enabled = false;
            txtGuess.Enabled = false;
            lblGuessedDigits.Text = "";
            lblCorrectPositions.Text = "";
            attempts = 0;
            UpdateStatusStrip();
            secretNumber = "";
            stopwatch.Reset();
            timer.Stop();
        }

        private void StartNewGame()
        {
            digitsCount = (int)numericUpDownDigits.Value;
            secretNumber = GenerateNumber(digitsCount);
            attempts = 0;
            stopwatch.Restart();

            btnStart.Enabled = false;
            btnReset.Enabled = true;
            txtGuess.Enabled = true;
            txtGuess.Text = "";
            txtGuess.Focus();

            lblGuessedDigits.Text = "";
            lblCorrectPositions.Text = "";

            timer.Start();
            UpdateStatusStrip();
        }

        private string GenerateNumber(int digits)
        {
            Random random = new Random();
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string result = "";

            int index = random.Next(numbers.Count);
            result += numbers[index].ToString();
            numbers.RemoveAt(index);
            numbers.Add(0);

            for (int i = 1; i < digits; i++)
            {
                index = random.Next(numbers.Count);
                result += numbers[index].ToString();
                numbers.RemoveAt(index);
            }

            return result;
        }

        private void ProcessGuess()
        {
            string guess = txtGuess.Text.Trim();

            if (guess.Length != digitsCount)
            {
                MessageBox.Show($"Введите {digitsCount}-значное число!", "Ошибка",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            attempts++;
            var (correctDigits, correctPositions) = CheckGuess(secretNumber, guess);

            lblGuessedDigits.Text = correctDigits.ToString();
            lblCorrectPositions.Text = correctPositions.ToString();

            if (correctPositions == digitsCount)
            {
                GameWon();
            }

            UpdateStatusStrip();
            txtGuess.Text = "";
            txtGuess.Focus();
        }

        private (int correctDigits, int correctPositions) CheckGuess(string secret, string guess)
        {
            int correctDigits = 0;
            int correctPositions = 0;

            for (int i = 0; i < secret.Length; i++)
            {
                if (secret.Contains(guess[i].ToString()))
                {
                    correctDigits++;
                }

                if (secret[i] == guess[i])
                {
                    correctPositions++;
                }
            }

            return (correctDigits, correctPositions);
        }

        private void GameWon()
        {
            stopwatch.Stop();
            timer.Stop();
            txtGuess.Enabled = false;

            MessageBox.Show($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток и {stopwatch.Elapsed.TotalSeconds:F1} секунд.",
                          "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

private void UpdateStatusStrip()
        {
            toolStripAttempts.Text = $"Попыток: {attempts}";
            toolStripTimeText.Text = $"Время: {stopwatch.Elapsed.TotalSeconds:F1} сек.";
        }

        private void btnStart_Click(object sender, EventArgs e) => StartNewGame();
        private void btnReset_Click(object sender, EventArgs e) => InitializeGame();
        private void btnExit_Click(object sender, EventArgs e) => Close();

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ProcessGuess();
        }

        private void timer_Tick(object sender, EventArgs e) => UpdateStatusStrip();
    }
}
