using System;
using System.Collections.Generic;
using System.Text;

namespace pokecenter
{
    public interface ICombatReady
    {
        int Attack(ICombatReady opponent);
        bool IsWon();
    }
}
