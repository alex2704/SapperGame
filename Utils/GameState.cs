using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public enum GameState
    {
        BEFORE_START, //игра не начилась
        PLAYING, //игра идет
        WIN, //игра закончилась победой
        FAIL //игра закончилась поражением
    }
}
