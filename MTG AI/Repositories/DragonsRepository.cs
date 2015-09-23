using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MTG_AI.DTO_s;
using CsvHelper;
using System.IO;

namespace MTG_AI.Repositories
{
    public class DragonsRepository
    {
        public IEnumerable<Creature> GetDragonCreatures()
        {
            List<Creature> dragonCreatures = new List<Creature>();
            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Dragons/DragonCreatures.csv")));


            while (csvReader.Read())
            {
                dragonCreatures.Add(new Creature
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

            return dragonCreatures;
        }

        public IEnumerable<Instant> GetDragonInstants()
        {
            List<Instant> dragonInstants = new List<Instant>();
            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Dragons/DragonInstants.csv")));

            while (csvReader.Read())
            {
                dragonInstants.Add(new Instant
                    {
                        CardName = csvReader.GetField(0),
                        GreenCost = Convert.ToInt32(csvReader.GetField(1)),
                        WhiteCost = Convert.ToInt32(csvReader.GetField(2)),
                        RedCost = Convert.ToInt32(csvReader.GetField(3)),
                        ColorlessCost = Convert.ToInt32(csvReader.GetField(4))
                    });
            }

            return dragonInstants;
        }

        public IEnumerable<Enchantment> GetDragonEnchantment()
        {
            List<Enchantment> dragonEnchantments = new List<Enchantment>();
            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Dragons/DragonEnchantments.csv")));

            while (csvReader.Read())
            {
                dragonEnchantments.Add(new Enchantment
                    {
                        CardName = csvReader.GetField(0),
                        GreenCost = Convert.ToInt32(csvReader.GetField(1)),
                        WhiteCost = Convert.ToInt32(csvReader.GetField(2)),
                        RedCost = Convert.ToInt32(csvReader.GetField(3)),
                        ColorlessCost = Convert.ToInt32(csvReader.GetField(4)),
                        GlobalEnchantment = Convert.ToInt32(csvReader.GetField(5))
                    });
            }

            return dragonEnchantments;
        }

        public IEnumerable<Land> GetDragonLands()
        {
            List<Land> dragonLand = new List<Land>();

            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Dragons/DragonLand.csv")));

            while (csvReader.Read())
            {
                dragonLand.Add(new Land
                {
                    CardName = csvReader.GetField(0),
                    GreenCost = Convert.ToInt32(csvReader.GetField(1)),
                    RedCost = Convert.ToInt32(csvReader.GetField(2)),
                    WhiteCost = Convert.ToInt32(csvReader.GetField(3)),
                    ColorlessCost = Convert.ToInt32(csvReader.GetField(4))
                });
            }

            return dragonLand;
        }

        public IEnumerable<Artifact> GetDragonArtifacts()
        {
            List<Artifact> dragonArtifacts = new List<Artifact>();

            var csvReader = new CsvReader(new StreamReader(Path.Combine(@"" + AppDomain.CurrentDomain.BaseDirectory, "Dragons/DragonArtifacts.csv")));

            while (csvReader.Read())
            {
                dragonArtifacts.Add(new Artifact
                    {
                        CardName = csvReader.GetField(0),
                        GreenCost = Convert.ToInt32(csvReader.GetField(1)),
                        RedCost = Convert.ToInt32(csvReader.GetField(2)),
                        WhiteCost = Convert.ToInt32(csvReader.GetField(3)),
                        ColorlessCost = Convert.ToInt32(csvReader.GetField(4))
                    });
            }

            return dragonArtifacts;
        }
    }
}
