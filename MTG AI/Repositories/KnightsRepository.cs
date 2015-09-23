using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MTG_AI.DTO_s;
using CsvHelper;
using System.IO;

namespace MTG_AI.Repositories
{
    public class KnightsRepository
    {
        public IEnumerable<Creature> GetKnightCreatures()
        {
            List<Creature> knightCreatures = new List<Creature>();
            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Knights/KnightCreatures.csv")));

            while (csvReader.Read())
            {
                knightCreatures.Add(new Creature
                {
                    CardName = csvReader.GetField(0),
                    Power = Convert.ToInt32(csvReader.GetField(1)),
                    Toughness = Convert.ToInt32(csvReader.GetField(2)),
                    Flying = Convert.ToInt32(csvReader.GetField(3)),
                    FirstStrike = Convert.ToInt32(csvReader.GetField(4)),
                    DoubleStrike = Convert.ToInt32(csvReader.GetField(5)),
                    LifeLink = Convert.ToInt32(csvReader.GetField(6)),
                    Vigilance = Convert.ToInt32(csvReader.GetField(7)),
                    Flash = Convert.ToInt32(csvReader.GetField(8)),
                    ProtectionFromRed = Convert.ToInt32(csvReader.GetField(9)),
                    Changeling = Convert.ToInt32(csvReader.GetField(10)),
                    GreenCost = Convert.ToInt32(csvReader.GetField(11)),
                    WhiteCost = Convert.ToInt32(csvReader.GetField(12)),
                    RedCost = Convert.ToInt32(csvReader.GetField(13)),
                    ColorlessCost = Convert.ToInt32(csvReader.GetField(14)),
                    Priority = Convert.ToInt32(csvReader.GetField(15))
                });
            }

            return knightCreatures;
        }

        public IEnumerable<Instant> GetKnightInstants()
        {
            List<Instant> knightInstants = new List<Instant>();
            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Knights/KnightInstants.csv")));

            while (csvReader.Read())
            {
                knightInstants.Add(new Instant
                {
                    CardName = csvReader.GetField(0),
                    GreenCost = Convert.ToInt32(csvReader.GetField(1)),
                    WhiteCost = Convert.ToInt32(csvReader.GetField(2)),
                    RedCost = Convert.ToInt32(csvReader.GetField(3)),
                    ColorlessCost = Convert.ToInt32(csvReader.GetField(4))
                });
            }

            return knightInstants;
        }

        public IEnumerable<Enchantment> GetKnightEnchantments()
        {
            List<Enchantment> knightEnchantments = new List<Enchantment>();
            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Knights/KnightEnchantments.csv")));

            while (csvReader.Read())
            {
                knightEnchantments.Add(new Enchantment
                {
                    CardName = csvReader.GetField(0),
                    GreenCost = Convert.ToInt32(csvReader.GetField(1)),
                    WhiteCost = Convert.ToInt32(csvReader.GetField(2)),
                    RedCost = Convert.ToInt32(csvReader.GetField(3)),
                    ColorlessCost = Convert.ToInt32(csvReader.GetField(4)),
                    GlobalEnchantment = Convert.ToInt32(csvReader.GetField(5))
                });
            }

            return knightEnchantments;
        }

        public IEnumerable<Equipment> GetKnightEquipment()
        {
            List<Equipment> knightEquipment = new List<Equipment>();
            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Knights/KnightEquipment.csv")));
            while(csvReader.Read())
            {
                knightEquipment.Add(new Equipment
                {
                    CardName = csvReader.GetField(0),
                    GreenCost = Convert.ToInt32(csvReader.GetField(1)),
                    WhiteCost = Convert.ToInt32(csvReader.GetField(2)),
                    ColorlessCost = Convert.ToInt32(csvReader.GetField(3)),
                    EquipCost = Convert.ToInt32(csvReader.GetField(4))
                });
            }

            return knightEquipment;
        }

        public IEnumerable<Land> GetLands()
        {
            List<Land> knightLands = new List<Land>();
            var csvreader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Knights/KnightLand.csv")));
            while(csvreader.Read())
            {
                knightLands.Add(new Land
                {
                    CardName = csvreader.GetField(0),
                    GreenCost = Convert.ToInt32(csvreader.GetField(1)),
                    RedCost = Convert.ToInt32(csvreader.GetField(2)),
                    WhiteCost = Convert.ToInt32(csvreader.GetField(3)),
                    ColorlessCost = Convert.ToInt32(csvreader.GetField(4))
                });
            }

            return knightLands;
        }
    }
}
