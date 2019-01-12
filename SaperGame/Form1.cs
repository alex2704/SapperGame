using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace SaperGame
{
    public partial class SapperForm : Form
    {
        private static StringFormat cellStringFormat = null;
        static SapperForm()
        {
            cellStringFormat = new StringFormat();
            cellStringFormat.Alignment = StringAlignment.Center;
            cellStringFormat.LineAlignment = StringAlignment.Center;
        }
        public SapperForm()
        {
            InitializeComponent();
        }
        SoundPlayer startGameSound = new SoundPlayer(@"Hello.wav");
        SoundPlayer FailSound = new SoundPlayer(@"Explosion.wav");
        private const int CELL_SIZE = 25;
        private SapperGame game = new SapperGame();
        private int time = 0;
        private void SapperForm_Load(object sender, EventArgs e)
        {
            //настройка dgv
            gameFieldDataGridView.RowTemplate.Height = CELL_SIZE;
            gameFieldDataGridView.Font = new Font("Comic Sans MS", 12);
            DataGridViewUtils.InitGridForArr(gameFieldDataGridView, CELL_SIZE, true, false, false, false, false);
            newGameButton.PerformClick();
        }
        Graphics g;
        private void UpdateView()
        {
            //обращаемся к Game
            //
            if(game.State == GameState.BEFORE_START)
            {
                label.Text = "Добро пожаловать";
            }
            if (game.State == GameState.FAIL)
            {
                timer.Enabled = false;
                FailSound.Play();
                label.Text = "Увы, вы проиграли";
            }
            if (game.State == GameState.PLAYING)
            {
                label.Text = "Игра началась...";
                score_lbl.Text = "Счёт: "+Convert.ToString(game.check);
            }
            if (game.State == GameState.WIN)
            {
                timer.Enabled = false;
                label.Text = "Поздравляем! Вы победили";
            }
            gameFieldDataGridView.Invalidate();
        }
        private void newGameButton_Click(object sender, EventArgs e)
        {
            startGameSound.Play();
            time = 0;
            g = CreateGraphics();
            g.Clear(gameFieldDataGridView.BackColor);
            game.NewGame(Convert.ToInt32(Height_box.Text), Convert.ToInt32(Width_box.Text), Convert.ToInt32(Mine_box.Text));
            gameFieldDataGridView.RowCount = game.RowCount;
            gameFieldDataGridView.ColumnCount = game.ColCount;
            gameFieldDataGridView.Width = game.ColCount * CELL_SIZE + 3;
            gameFieldDataGridView.Height = game.RowCount * CELL_SIZE + 3;
            game.Generate();
            UpdateView();
            timer.Enabled = true;
        }
        private void gameFieldDataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            string content;
            //отрисовка фона
            SapperCell cell = game.Field[e.RowIndex, e.ColumnIndex];
            e.CellStyle.BackColor = cell.state == CellState.OPEN ? Color.White : Color.LightGray;
            if (cell.state == CellState.OPEN && cell.mine)
                e.CellStyle.BackColor = Color.Black;
            e.PaintBackground(e.CellBounds, false);
            g = e.Graphics;
            Rectangle rect = e.CellBounds;
            Point p0 = rect.Location;
            Point p1 = new Point(p0.X + 5, p0.Y + 1);
            //отрисовка цифр
            if (cell.state == CellState.OPEN && cell.mine == false && cell.aroundMinesCount!=0)
            {
                content = Convert.ToString(cell.aroundMinesCount);
                e.Graphics.DrawString(content, gameFieldDataGridView.Font, Brushes.Black, e.CellBounds, cellStringFormat);
            }
            if (cell.state == CellState.OPEN && cell.mine == false && cell.aroundMinesCount == 0)
            {
                content ="";
                e.Graphics.DrawString(content, gameFieldDataGridView.Font, Brushes.Black, e.CellBounds, cellStringFormat);
            }
            if (cell.state == CellState.OPEN && cell.mine == true)//проигрыш
            {
                content = "*";
                e.Graphics.DrawString(content, gameFieldDataGridView.Font, Brushes.Red, e.CellBounds, cellStringFormat);
            }
            //отрисовка флага
            if(cell.state == CellState.FLAG)
            {
                PointF point1 = new PointF(p0.X + 3, p0.Y + 3);
                PointF point2 = new PointF(p0.X + 3, p0.Y + 10);
                PointF point3 = new PointF(p0.X+CELL_SIZE-5,p0.Y+5);
                PointF[] points = {
                   point1,point2,point3
                };
                    g.DrawLine(Pens.Black, p0.X + 3, p0.Y + 3, p0.X + 4, p0.Y + CELL_SIZE - 2);
                    g.DrawPolygon(Pens.Red, points);
                    g.FillPolygon(Brushes.Red, points);
            }
            //отрисовка вопроса
            if(cell.state == CellState.PROBLEM)
            {
                content = "?";
                e.Graphics.DrawString(content,gameFieldDataGridView.Font,Brushes.Black,e.CellBounds,cellStringFormat);
                cell.state = CellState.HIDDEN;
            }
            if(cell.state == CellState.REHIDDEN)
            {
                content = "";
                e.Graphics.DrawString(content, gameFieldDataGridView.Font, Brushes.Black, e.CellBounds, cellStringFormat);
            }
            //сообщаем, что ячейка грида полностью отрисована
            e.Handled = true;
        }

        private void gameFieldDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                int s = e.RowIndex;
                int l = e.ColumnIndex;
                game.LeftMouseClick(e.RowIndex, e.ColumnIndex);
                UpdateView();
            }
            if(e.Button == MouseButtons.Right)
            {
                game.RightMouseClick(e.RowIndex, e.ColumnIndex);
                UpdateView();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer_lbl.Text = Convert.ToString(time);
            time++;
        }
    }
}
