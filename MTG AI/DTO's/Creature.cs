using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTG_AI.DTO_s
{
    public class Creature : ICard
    {
        public string CardName { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public int Flying { get; set; }
        public int FirstStrike { get; set; }
        public int DoubleStrike { get; set; }
        public int LifeLink { get; set; }
        public int Vigilance { get; set; }
        public int Flash { get; set; }
        public int ProtectionFromRed { get; set; }
        public int Changeling { get; set; }
        public int GreenCost { get; set; }
        public int WhiteCost { get; set; }
        public int RedCost { get; set; }
        public int ColorlessCost { get; set; }
        public bool IsTapped { get; set; }
        public int Priority { get; set; }
        public int TotalManaCost
        {
            get
            {
                return GreenCost + RedCost + WhiteCost + ColorlessCost;
            }
        }
        public bool IsSick { get; set; }
        public List<Enchantment> CreatureEnchantments { get; set; }
        public List<Equipment> CreatureEquipment { get; set; }
        public Creature()
        {
            CreatureEnchantments = new List<Enchantment>();
            CreatureEquipment = new List<Equipment>();
        }

        public override string ToString()
        {
            return CardName;
        }        
    }
}
