using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTG_AI.DTO_s
{
    public class Instant : ICard
    {
        public string CardName { get; set; }
        public int GreenCost { get; set; }
        public int WhiteCost { get; set; }
        public int RedCost { get; set; }
        public int ColorlessCost { get; set; }
        public int TotalManaCost
        {
            get
            {
                return GreenCost + RedCost + WhiteCost + ColorlessCost;
            }
        }

        public override string ToString()
        {
            return CardName;
        }
    }
}
