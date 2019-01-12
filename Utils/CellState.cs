using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public enum CellState
    {
        REHIDDEN,//использовалась но снова стала закрытой
        HIDDEN, //клетка закрыта
        OPEN, //клетк открыта(взрыв или разминирована)
        FLAG, //поставлен флаг
        PROBLEM //поставлен вопрос(неизвестно)
    }
}
