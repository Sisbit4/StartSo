using System;
using System.Drawing;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class MainForm : Form
    {
        private const int BoardSize = 8;
        private const int CellSize = 50;
        private Button[,] boardButtons;
        private bool[,] boardState;

        public MainForm()
        {
            InitializeComponent();
            InitializeBoard();
            SetupFlatMenu();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void InitializeBoard()
        {
            boardButtons = new Button[BoardSize, BoardSize];
            boardState = new bool[BoardSize, BoardSize];

            int startX = (this.ClientSize.Width - BoardSize * CellSize) / 2;
            int startY = menuStrip1.Height + 20;

            for (int row = 0; row < BoardSize; row++)
            {
                for (int col = 0; col < BoardSize; col++)
                {
                    boardButtons[row, col] = new Button
                    {
                        Size = new Size(CellSize, CellSize),
                        Location = new Point(startX + col * CellSize, startY + row * CellSize),
                        Tag = new Point(row, col),
                        BackColor = Color.White
                    };
                    boardButtons[row, col].Click += Cell_Click;
                    this.Controls.Add(boardButtons[row, col]);

                    boardState[row, col] = false;
                }
            }
        }

        private void SetupFlatMenu()
        {
            // Убираем выпадающее меню
            menuStrip1.ShowItemToolTips = true;

            // Делаем пункты меню видимыми напрямую
            ToolStripMenuItem resetItem = new ToolStripMenuItem("Сброс");
            resetItem.Click += (s, e) => ResetBoard();

            ToolStripMenuItem exitItem = new ToolStripMenuItem("Выход");
            exitItem.Click += (s, e) => this.Close();

            menuStrip1.Items.AddRange(new ToolStripItem[] { resetItem, exitItem });
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point position = (Point)clickedButton.Tag;
            int row = position.X;
            int col = position.Y;

            for (int i = 0; i < BoardSize; i++)
            {
                boardState[i, col] = !boardState[i, col];
                boardButtons[i, col].BackColor = boardState[i, col] ? Color.Black : Color.White;

                if (i != col)
                {
                    boardState[row, i] = !boardState[row, i];
                    boardButtons[row, i].BackColor = boardState[row, i] ? Color.Black : Color.White;
                }
            }

            if (CheckWinCondition())
                MessageBox.Show("Поздравляем! Вы решили головоломку!", "Победа",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckWinCondition()
        {
            foreach (var cell in boardState)
                if (!cell) return false;
            return true;
        }

        private void ResetBoard()
        {
            for (int row = 0; row < BoardSize; row++)
                for (int col = 0; col < BoardSize; col++)
                {
                    boardState[row, col] = false;
                    boardButtons[row, col].BackColor = Color.White;
                }
        }
    }
}