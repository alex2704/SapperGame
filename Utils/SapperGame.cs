using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class SapperGame
    {
        public int RowCount { get; protected set; } = 0;
        public int ColCount { get; protected set; } = 0;
        public int MineCount { get; protected set; } = 0;
        public GameState State
        {
            get
            {
                return state;
            }
            set
            {

            }
        }
        public SapperCell[,] Field { get; protected set; }
        public SapperGame()
        {

        }
        private Random rnd = new Random();
        private GameState state = GameState.BEFORE_START;//состояние игры
        public void NewGame(int rowCount, int colCount, int mineCount)
        {
            RowCount = rowCount;
            ColCount = colCount;
            MineCount = mineCount;
            state = GameState.PLAYING;
        }
        public int check = 0;
        //
        //
        //
        //
        private void CalcGameState()
        {
            if(check == RowCount * ColCount - MineCount)
            {
                state = GameState.WIN;
            }
                    
        }
        public void LeftMouseClick(int row, int col)
        {
            if (row < 0 || col < 0 || row >= RowCount || col >= ColCount || state != GameState.PLAYING || Field[row, col].state == CellState.OPEN || Field[row,col].state == CellState.FLAG)
                return;
            Field[row, col].state = CellState.OPEN;
            check++;
            if (Field[row, col].mine == true)
            {
                state = GameState.FAIL;
                OpenAllCells();
                return;
            }
            Field[row, col].countTaps = 0;
            Field[row, col].check = true;
            CalcGameState();
            if (Field[row, col].aroundMinesCount == 0)
                OpenEmptyCells(row, col);
        }
        private void OpenEmptyCells(int row, int col)
        {
            //if (Field[row, col].check == false)
            //{
                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i >= 0 && j >= 0 && i < RowCount && j < ColCount && Field[row, col].aroundMinesCount == 0 && Field[i, j].check == false)//&& (i != row || j != col)
                    {
                            Field[i, j].state = CellState.OPEN;
                            Field[i, j].check = true;
                            ++check;
                            OpenEmptyCells(i, j);
                        }
                        else if (i >= 0 && j >= 0 && i < RowCount && j < ColCount && Field[row,col].state != CellState.OPEN && Field[i,j].check == false)//&& (i != row || j != col)
                        {
                            Field[i, j].check = true;
                            Field[i, j].state = CellState.OPEN;
                            ++check;
                        }
                    }
                }
            //}
        }
        public void RightMouseClick(int row, int col)
        {
            if (row < 0 || col < 0 || row >= RowCount || col >= ColCount || state != GameState.PLAYING || Field[row, col].state == CellState.OPEN)
                return;
            Field[row, col].countTaps++;
            if (Field[row, col].countTaps % 2 == 0)
            {
                Field[row, col].state = CellState.PROBLEM;
            }
            if (Field[row, col].countTaps % 3 == 0)
            {
                Field[row, col].state = CellState.REHIDDEN;
                Field[row, col].countTaps = 0;
            }
            if (Field[row, col].countTaps - 1 == 0) 
                Field[row, col].state = CellState.FLAG;
        }
        private void SortOut(int r, int c)
        {
            int minesCount = 0;
            for(int i = r - 1; i <= r + 1; i++)
            {
                for(int j = c-1; j <= c + 1; j++)
                {
                    if (0 <= i && i < RowCount && 0 <= j && j < ColCount && (i != r || j != c))
                    {
                        if (Field[i, j].mine == true)
                        {
                            minesCount++;
                        }
                    }
                }
            }
            Field[r, c].aroundMinesCount = minesCount;
        }
        public void Generate()
        {
            GenerateField();
        }
        private void GenerateField()
        {
            check = 0;
            Field = new SapperCell[RowCount,ColCount];
            state = GameState.PLAYING;
            for (int m = 0; m < RowCount; m++)
            {
                for (int n = 0; n < ColCount; n++)
                {
                    Field[m, n] = new SapperCell(false, CellState.HIDDEN, 0);
                }
            }
            int k, l;
            for(int i = 0; i < MineCount; i++)
            {
                k = rnd.Next(0, RowCount);
                l = rnd.Next(0, ColCount);
                if (Field[k, l].stayBomb == true)
                {
                    Field[k, l].mine = true;
                    for (int t = k - 1; t <= k + 1; t++)
                    {
                        for (int z = l - 1; z <= l + 1; z++)
                        {
                            if (t >= 0 && t < RowCount && z >= 0 && z < ColCount)
                            {
                                Field[t, z].stayBomb = false;
                            }
                        }
                    }
                }
                else
                {
                    i--;
                }
            }
            for (int q = 0; q < RowCount; q++)
            {
                for (int w = 0; w < ColCount; w++)
                {
                    SortOut(q, w);
                }
            }
        }
        public void OpenAllCells()
        {
            for (int q = 0; q < RowCount; q++)
            {
                for (int w = 0; w < ColCount; w++)
                {
                    if (Field[q, w].mine == true)
                        Field[q, w].state = CellState.OPEN;
                }
            }
        }
    }
}
