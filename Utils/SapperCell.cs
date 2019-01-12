using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public struct SapperCell
    {
        public bool mine; //наличие мины
        public CellState state; // состояние клетки
        public int aroundMinesCount; //количество мин вокруг клетки
        public bool stayBomb;//можно ли поставить сюда бомбу
        public int countTaps;//кол-во нажатий на ячейку
        public bool check;//проверена на открытие?

        public SapperCell(bool mine, CellState state, int aroundMinesCount, bool stayBomb = true, int countTaps = 0,  bool check = false)
        {
            this.mine = mine;
            this.state = state;
            this.aroundMinesCount = aroundMinesCount;
            this.stayBomb = stayBomb;
            this.countTaps = countTaps;
            this.check = false;
        }
    }
}
