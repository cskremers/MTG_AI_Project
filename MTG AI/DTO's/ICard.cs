using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTG_AI.DTO_s
{
    public interface ICard
    {
        string CardName { get; set; }
        int GreenCost { get; set; }
        int WhiteCost { get; set; }
        int RedCost { get; set; }
        int ColorlessCost { get; set; }
        int TotalManaCost { get; }
    }
}
