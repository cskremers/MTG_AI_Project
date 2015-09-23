using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTG_AI.Repositories;

namespace MTG.AI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DragonCreaturesPopulateFromFile()
        {
            var dragonsRepo = new DragonsRepository();

            var dragonCreatures = dragonsRepo.GetDragonCreatures();

            string x = "";
        }

        [TestMethod]
        public void DragonEnchantmentsPopulateFromFile()
        {
            var dragonsRepo = new DragonsRepository();

            var dragonEnchantments = dragonsRepo.GetDragonEnchantment();

            string x = "";
        }

        [TestMethod]
        public void DragonInstantsPopulateFromFile()
        {
            var dragonsRepo = new DragonsRepository();

            var dragonInstants = dragonsRepo.GetDragonEnchantment();

            string x = "";
        }

        [TestMethod]
        public void KnightCreaturesPopulateFromFile()
        {
            var knightsRepo = new KnightsRepository();

            var knightCreatures = knightsRepo.GetKnightCreatures();

            string x = "";
        }

        [TestMethod]
        public void KnightEnchantmentsPopulatefromFile()
        {
            var knightsRepo = new KnightsRepository();

            var knightEnchantments = knightsRepo.GetKnightEnchantments();

            string x = "";
        }

        [TestMethod]
        public void KnightsInstantsPopulateFromFile()
        {
            var knightsRepo = new KnightsRepository();

            var knightsInstants = knightsRepo.GetKnightInstants();

            string x = "";
        }

        [TestMethod]
        public void KnightEquipmentPopulatesFromFile()
        {
            var knightsRepo = new KnightsRepository();

            var kinghtEquipment = knightsRepo.GetKnightEquipment();

            string x = "";
        }
    }
}
