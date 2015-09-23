// Created by Denton Bobeldyk Summer 2013 for CISP 280
// gamestate holds the current game state for the AI program
// (C) Bobeldyk 2013

// Could make this serializable in the future so you can save game states and reload them. This would allow faster testing of the AI
// so you don't have to load the game state by hand every time.

// Modified by: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using MTG_AI.DTO_s;

namespace MTG_AI
{
    [Serializable]
    public class gameState
    {
        public List<ICard> DragonCards { get; set; }
        public List<ICard> KnightCards { get; set; }       

        public IEnumerable<Creature> KnightCreatures { get; set; }
        public IEnumerable<Creature> DragonCreatures { get; set; }

        public IEnumerable<Enchantment> KnightEnchantments { get; set; }
        public IEnumerable<Enchantment> DragonEnchantments { get; set; }

        public IEnumerable<Enchantment> AllEnchantments { get; set; }

        public IEnumerable<Equipment> Equipment { get; set; }

        public IEnumerable<Instant> KnightInstants { get; set; }
        public IEnumerable<Instant> DragonInstants { get; set; }

        public int MyLife { get; set; }
        public int OpponentLife { get; set; }
        public string CurrentGameState { get; set; }

        public List<Creature> MyCreatures { get; set; }
        public List<Creature> OpponentCreatures { get; set; }

        public List<Enchantment> MyEnchantments { get; set; }
        public List<Enchantment> OpponentEnchantments { get; set; }

        public List<Equipment> MyEquipment { get; set; }
        public List<Equipment> OpponentEquipment { get; set; }

        public List<ICard> MyHand {get; set;}

        public int MulliganCount { get; set; }

        public bool PlayedLand { get; set; }
               
        //private int sizeOfOpponentsHand; // students can implement this if they choose

        // Direct access to these variables. Yes, I know some people will scream.
        public int myPlains;
        public int myForests;
        public int myGrasslands;
        public int mySelesnyaSanctuary;
        public int mySejiriSteppe;
        public int myTreeTopVillage;
        public int myMountains; // If playing Dragons

        public int DragonsMana;
        public int KnightsMana;

        public int opponentPlains;
        public int opponentForests;
        public int opponentGrasslands;
        public int opponentSelesnyaSanctuary;
        public int opponentSejiriSteppe;
        public int opponentTreeTopVillage;
        public int opponentMountains; // If opponent playing Dragons
        
        public gameState()
        {
            KnightCreatures = new List<Creature>();
            KnightEnchantments = new List<Enchantment>();
            KnightInstants = new List<Instant>();
            Equipment = new List<Equipment>();
            KnightCards = new List<ICard>();

            DragonCreatures = new List<Creature>();
            DragonEnchantments = new List<Enchantment>();
            DragonInstants = new List<Instant>();

            DragonCards = new List<ICard>();

            AllEnchantments = new List<Enchantment>();

            MyCreatures = new List<Creature>();
            MyEnchantments = new List<Enchantment>();
            MyEquipment = new List<Equipment>();
            MyHand = new List<ICard>();

            OpponentCreatures = new List<Creature>();
            OpponentEnchantments = new List<Enchantment>();
            OpponentEquipment = new List<Equipment>();

            myPlains = 0;
            myForests = 0;
            myGrasslands = 0;
            mySelesnyaSanctuary = 0;
            mySejiriSteppe = 0;
            myTreeTopVillage = 0;
            myMountains = 0;

            opponentPlains = 0;
            opponentForests = 0;
            opponentGrasslands = 0;
            opponentSelesnyaSanctuary = 0;
            opponentSejiriSteppe = 0;
            opponentTreeTopVillage = 0;
            opponentMountains = 0;
        }    
       
        public bool RemoveMyCreature(Creature creatureToRemove)
        {
            if(MyCreatures.Contains(creatureToRemove))
            {
                MyCreatures.Remove(creatureToRemove);
                return true;
            }
            else
            {
                return false;
            }            
        }

        public bool RemoveOpponentCreature(Creature creatureToRemove)
        {
            if(MyCreatures.Contains(creatureToRemove))
            {
                OpponentCreatures.Remove(creatureToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Creature> GetMyCreaturesEquipped()
        {
            List<Creature> currentlyEquippedCreatures = new List<Creature>();

            foreach (Creature iterateCreature in MyCreatures)
            {
                if (iterateCreature.CreatureEquipment.Count > 0)
                {
                    currentlyEquippedCreatures.Add(iterateCreature);
                }
            }

            return currentlyEquippedCreatures;
        }

        public List<Creature> GetOpponentCreaturesEquipped()
        {
            List<Creature> currentlyEquippedCreatures = new List<Creature>();

            foreach(var creature in OpponentCreatures)
            {
                if(creature.CreatureEquipment.Count > 0)
                {
                    currentlyEquippedCreatures.Add(creature);
                }
            }

            return currentlyEquippedCreatures;
        }
    }
}
