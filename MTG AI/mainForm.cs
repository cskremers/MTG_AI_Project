/*-----------------------------------------------------------------------------------------
 *   mainForm was written as a GUI to handle modifying the state for our MTG game.
 *   Students should be able to write code to query the gameState. 
 *   
 *   No need to modify any code below unless you want to track additional states of the game
 *   
 * 
 *  Written by: Denny Bobeldyk Summer 2013
 *  Modified by: <insert your name here>
 * --------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MTG_AI.DTO_s;
using MTG_AI.Repositories;

namespace MTG_AI
{
    public partial class mainForm : Form
    {
        gameState currentGameState;
        DragonsRepository dragonRepo;
        KnightsRepository knightsRepo;

        StringBuilder whatToDoSB = new StringBuilder();

        public mainForm()
        {
            InitializeComponent();

            currentGameState = new gameState();
            currentGameState.PlayedLand = false;
            knightsRepo = new KnightsRepository();
            dragonRepo = new DragonsRepository();

            currentGameState.KnightCreatures = knightsRepo.GetKnightCreatures().ToList();
            currentGameState.KnightEnchantments = knightsRepo.GetKnightEnchantments().ToList();
            currentGameState.KnightInstants = knightsRepo.GetKnightInstants().ToList();
            currentGameState.Equipment = knightsRepo.GetKnightEquipment().ToList();

            currentGameState.KnightCards.AddRange(currentGameState.KnightCreatures.Cast<ICard>());
            currentGameState.KnightCards.AddRange(currentGameState.KnightEnchantments.Cast<ICard>());
            currentGameState.KnightCards.AddRange(currentGameState.KnightInstants.Cast<ICard>());
            currentGameState.KnightCards.AddRange(currentGameState.Equipment.Cast<ICard>());
            currentGameState.KnightCards.AddRange(knightsRepo.GetLands().Cast<ICard>());

            currentGameState.DragonCreatures = dragonRepo.GetDragonCreatures().ToList();
            currentGameState.DragonEnchantments = dragonRepo.GetDragonEnchantment().ToList();
            currentGameState.DragonInstants = dragonRepo.GetDragonInstants().ToList();
           

            currentGameState.DragonCards.AddRange(currentGameState.DragonCreatures.Cast<ICard>());
            currentGameState.DragonCards.AddRange(currentGameState.DragonEnchantments.Cast<ICard>());
            currentGameState.DragonCards.AddRange(currentGameState.DragonInstants.Cast<ICard>());
            currentGameState.DragonCards.AddRange(dragonRepo.GetDragonLands().Cast<ICard>());
            currentGameState.DragonCards.AddRange(dragonRepo.GetDragonArtifacts().Cast<ICard>());

            currentGameState.AllEnchantments = currentGameState.KnightEnchantments.Concat(currentGameState.DragonEnchantments);
        }

        #region GUI Changes

        private void myLifeCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.MyLife = (int)myLifeCounter.Value;
        }

        private void opponentLifeCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.OpponentLife = (int)opponentLifeCounter.Value;
        }

        private void myMountainCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.myMountains = (int)myMountainCounter.Value;
            
        }

        private void myForestCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.myForests = (int)myForestCounter.Value;
            
        }

        private void mySelesnyaSanctuaryCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.mySelesnyaSanctuary = (int)mySelesnyaSanctuaryCounter.Value;
        }

        private void myPlainsCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.myPlains = (int)myPlainsCounter.Value;
            
        }

        private void myTreetopVillageCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.myTreeTopVillage = (int)myTreetopVillageCounter.Value;
        }

        private void mySejiriSteppeCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.mySejiriSteppe = (int)mySejiriSteppeCounter.Value;
        }

        #endregion

        #region Click Events

        private void myAddCreatureButton_Click(object sender, EventArgs e)
        {
            //Ask the user what Creature they would like to add and then add it
            //need a new listbox or user dialog, or textbox that when they start to type it auto completes
            addCreatureForm acf = new addCreatureForm(currentGameState);

            acf.ShowDialog();

            if (acf.getCreatureToAdd() != null)
            {
                currentGameState.MyCreatures.Add((acf.getCreatureToAdd()));
            }
            else
            {
                // If it's null, it may be that they just cancelled out of it, if so, we just won't add it
            }
        }

        private void removeMyCreatureButton_Click(object sender, EventArgs e)
        {
            if (currentGameState.MyCreatures.Count == 0)
            {
                MessageBox.Show("No Creatures currently in play");
            }
            else
            {
                removeCreatureForm rcf = new removeCreatureForm(currentGameState.MyCreatures);

                rcf.ShowDialog();

                Creature CreatureToRemove = rcf.getCreatureToRemove();

                if (currentGameState.RemoveMyCreature(CreatureToRemove))
                {
                    MessageBox.Show("Removed " + CreatureToRemove.ToString());
                }
                else
                {
                    MessageBox.Show("Remove Cancelled or Creature Not Found");
                }
            }

        }

        private void addEnchantmentButton_Click(object sender, EventArgs e)
        {
            addEnchantmentForm aef = new addEnchantmentForm(currentGameState, currentGameState.MyCreatures);

            aef.ShowDialog();

            currentGameState.MyEnchantments.Add(aef.GetEnchantment());

        }

        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            addEquipmentForm aef = new addEquipmentForm(currentGameState, currentGameState.MyCreatures);

            // We handle setting the equipment in the form
            aef.ShowDialog();


            if (aef.GetEquipment() != null)
            {
                MessageBox.Show("Equipment [" + aef.GetEquipment().ToString() + "] added to [" + aef.GetCreature().ToString() + "]");
            }
            else
            {
                MessageBox.Show("Equipment Add Cancelled");
            }
        }

        private void showMyBoardButton_Click(object sender, EventArgs e)
        {
            // I'd like to create something visual here, but for now, just dump it to the listbox
            // Need to decide if I want this to be a log or a game state display
            gameLogListBox.Items.Clear();
            gameLogListBox.Items.Add("=================My Hand=========================");

            foreach (object card in currentGameState.MyHand)
            {
                gameLogListBox.Items.Add(card.ToString());
            }
            gameLogListBox.Items.Add("===============Game State Shown=================");

            gameLogListBox.Items.Add("My Creatures");

            if (currentGameState.MyCreatures.Count == 0)
            {
                gameLogListBox.Items.Add("   None");
            }
            else
            {
                foreach (Creature c in currentGameState.MyCreatures)
                {
                    gameLogListBox.Items.Add("   " + c.ToString());
                }
            }

            gameLogListBox.Items.Add("Opponent Creatures");

            if (currentGameState.OpponentCreatures.Count == 0)
            {
                gameLogListBox.Items.Add("   None");
            }
            else
            {
                foreach (Creature c in currentGameState.OpponentCreatures)
                {
                    gameLogListBox.Items.Add("   " + c.ToString());
                }
            }

            gameLogListBox.Items.Add("My Enchantments");

            if (currentGameState.MyEnchantments.Count == 0)
            {
                gameLogListBox.Items.Add("   None");
            }
            else
            {
                foreach (var enchantment in currentGameState.MyEnchantments)
                {
                    gameLogListBox.Items.Add("   " + enchantment.ToString());

                }
            }

            gameLogListBox.Items.Add("Opponent Enchantments");
            if (currentGameState.OpponentEnchantments.Count == 0)
            {
                gameLogListBox.Items.Add("   None");
            }
            else
            {
                foreach (var enchantment in currentGameState.OpponentEnchantments)
                {
                    gameLogListBox.Items.Add("   " + enchantment.ToString());
                }
            }

            gameLogListBox.Items.Add("Equipment");

            // Let's check to see if the hammer is in play and is equipped
            bool myHammerEquipped = false;
            foreach (Creature c in currentGameState.MyCreatures)
            {
                if (c.CreatureEquipment.Count > 0)
                {
                    myHammerEquipped = true;
                }
            }

            if (myHammerEquipped)
            {
                // no need to display because it's already been displayed on the Creature
            }
            else
            {
                foreach (var equipment in currentGameState.MyEquipment)
                {
                    gameLogListBox.Items.Add("  Mine:  " + equipment.ToString());
                }
            }

            bool opponentHammerEquipped = false;

            foreach (Creature c in currentGameState.OpponentCreatures)
            {
                if (c.CreatureEquipment.Count > 0)
                {
                    opponentHammerEquipped = true;
                }
            }

            if (opponentHammerEquipped)
            {
                // No need to display because it's already been displayed on the Creature
            }
            else
            {
                foreach (var equipment in currentGameState.OpponentEquipment)
                {
                    gameLogListBox.Items.Add("   Opponent: " + equipment.ToString());
                }
            }
        }

        // Oblivion Ring is really the only card that can remove enchantments directly. But why target
        // the enchantment when you can remove the Creature and the enchantment falls off?

        private void removeEnchantmentButton_Click(object sender, EventArgs e)
        {
            if (currentGameState.MyEnchantments.Count == 0)
            {
                MessageBox.Show("No global enchantments to remove");
            }
            else
            {
                // I remove the enchantment in the form, I should modify this so it is removed here for consistency sake
                // for now it will be removed in the form
                removeEnchantmentForm reform = new removeEnchantmentForm(currentGameState.MyEnchantments);
                reform.ShowDialog();
            }
        }

        private void removeEquipmentButton_Click(object sender, EventArgs e)
        {
            if (currentGameState.GetMyCreaturesEquipped().Count > 0 || currentGameState.MyEquipment.Count > 0)
            {
                removeEquipmentForm reform = new removeEquipmentForm(currentGameState.MyCreatures, currentGameState.MyEquipment);

                reform.ShowDialog();
            }
            else
            {
                MessageBox.Show("No equipment in play to remove");
            }
        }

        private void addOpponentCreature_Click(object sender, EventArgs e)
        {
            // Ask the user what Creature they would like to add and then add it
            // need a new listbox or user dialog, or textbox that when they start to type it auto completes
            addCreatureForm acf = new addCreatureForm(currentGameState);

            acf.ShowDialog();

            if (acf.getCreatureToAdd() != null)
            {
                currentGameState.OpponentCreatures.Add((acf.getCreatureToAdd()));
            }
            else
            {
                // If it's null, it may be that they just cancelled out of it, if so, we just won't add it
            }
        }

        private void removeOpponentCreature_Click(object sender, EventArgs e)
        {
            if (currentGameState.OpponentCreatures.Count == 0)
            {
                MessageBox.Show("Your opponent currently has no Creatures in play");
            }
            else
            {
                removeCreatureForm rcf = new removeCreatureForm(currentGameState.OpponentCreatures);

                rcf.ShowDialog();

                Creature CreatureToRemove = rcf.getCreatureToRemove();

                if (currentGameState.RemoveOpponentCreature(CreatureToRemove))
                {
                    MessageBox.Show("Removed " + CreatureToRemove.ToString());
                }
                else
                {
                    MessageBox.Show("Remove Cancelled or Creature Not Found");
                }
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            turnCB.SelectedIndex = 0;
            stageCB.SelectedIndex = 0;
        }

        private void advanceNextStageButton_Click(object sender, EventArgs e)
        {
            if ((string)stageCB.SelectedItem == "Start of Game")
            {
                stageCB.Items.Remove("Start of Game");
            }

            if (stageCB.SelectedIndex == (stageCB.Items.Count - 1))
            {
                stageCB.SelectedIndex = 0;

                if (turnCB.SelectedIndex == (turnCB.Items.Count - 1))
                {
                    turnCB.SelectedIndex = 0;
                    MessageBox.Show("Maximum amount of turns exceeded, resetting to 1");
                }
                else
                {
                    //turnCB.SelectedIndex = turnCB.SelectedIndex + 1;
                    if (myTurnCB.Checked)
                    {
                        myTurnCB.Checked = false;
                        opponentsTurnCB.Checked = true;

                    }
                    else
                    {
                        opponentsTurnCB.Checked = false;
                        myTurnCB.Checked = true;
                    }
                }
            }
            else
            {
                stageCB.SelectedIndex = stageCB.SelectedIndex + 1;
            }
        }

        private void addOpponentEnchantment_Click(object sender, EventArgs e)
        {
            addEnchantmentForm aef = new addEnchantmentForm(currentGameState, currentGameState.OpponentCreatures);

            aef.ShowDialog();

            currentGameState.OpponentEnchantments.Add(aef.GetEnchantment());
        }

        private void addOpponentEquipment_Click(object sender, EventArgs e)
        {
            addEquipmentForm aef = new addEquipmentForm(currentGameState, currentGameState.OpponentCreatures);

            // We handle setting the equipment in the form
            aef.ShowDialog();


            if (aef.GetEquipment() != null)
            {
                MessageBox.Show("Equipment [" + aef.GetEquipment().ToString() + "] added to [" + aef.GetCreature().ToString() + "]");
            }
            else
            {
                MessageBox.Show("Equipment Add Cancelled");
            }
        }

        private void removeOpponentEnchantment_Click(object sender, EventArgs e)
        {
            if (currentGameState.OpponentEnchantments.Count == 0)
            {
                MessageBox.Show("No global enchantments to remove");
            }
            else
            {
                // I remove the enchantment in the form, I should modify this to it is removed here for consistency sake
                removeEnchantmentForm reform = new removeEnchantmentForm(currentGameState.OpponentEnchantments);
                reform.ShowDialog();
            }
        }

        private void removeOpponentEquipment_Click(object sender, EventArgs e)
        {
            if (currentGameState.GetOpponentCreaturesEquipped().Count > 0 || currentGameState.OpponentEquipment.Count > 0)
            {
                removeEquipmentForm reform = new removeEquipmentForm(currentGameState.OpponentCreatures, currentGameState.OpponentEquipment);

                reform.ShowDialog();
            }
            else
            {
                MessageBox.Show("No equipment in play to remove");
            }
        }

        private void addOpponentStack_Click(object sender, EventArgs e)
        {
            // students may implement this if they desire
            MessageBox.Show("Students may implement this if they desire.");
        }

        private void AddStackButton_Click(object sender, EventArgs e)
        {
            // students may implement this if they desire
            MessageBox.Show("Students may implement this if they desire.");
        }

        private void addMyArtifactButton_Click(object sender, EventArgs e)
        {
            // students may implement this if they desire
            MessageBox.Show("Students may implement this if they desire.");
        }

        private void addOpponentArtifactButton_Click(object sender, EventArgs e)
        {
            // students may implement this if they desire
            MessageBox.Show("Students may implement this if they desire.");
        }

        private void whatDoIDoButton_Click(object sender, EventArgs e)
        {
            // Query the game state and decide what you want to do
            // Most of your AI code will go here to determine your next move
            string whatToDo = "";

            string caseSwitch = currentGameState.CurrentGameState;

            if (myTurnCB.Checked)
            {
                switch (caseSwitch)
                {
                    case "Start of Game":
                        whatToDo = TakeMulligan();
                        break;
                    case "Untap":
                        //
                        whatToDo = upTap();
                        break;
                    case "Upkeep":
                        //
                        whatToDo = upKeep();
                        break;
                    case "Draw":
                        //
                        whatToDo = drawCard();
                        break;
                    case "Main Phase I":
                        //
                        whatToDo = mainPhaseI();
                        break;
                    case "Beginning of Combat":
                        //
                        whatToDo = beginningOfCombat();
                        break;
                    case "Declare Attackers":
                        //
                        whatToDo = OurDeclareAttackers();
                        break;
                    case "Declare Blockers":
                        //
                        whatToDo = OurDeclareBlockers();
                        break;
                    case "Combat Damage":
                        //
                        whatToDo = combatDamage();
                        break;
                    case "End of Combat":
                        //
                        whatToDo = endOfCombat();
                        break;
                    case "Main Phase II":
                        //
                        whatToDo = mainPhaseII();
                        break;
                    case "End Step":
                        //
                        whatToDo = endStep();
                        break;
                    case "Cleanup":
                        //
                        whatToDo = cleanUp();
                        break;
                }
            }
            else if (opponentsTurnCB.Checked)
            {
                switch (caseSwitch)
                {
                    case "Start of Game":
                        whatToDo = TakeMulligan();
                        break;
                    case "Untap":
                        //
                        whatToDo = upTap();
                        break;
                    case "Upkeep":
                        //
                        whatToDo = upKeep();
                        break;
                    case "Draw":
                        //
                        whatToDo = drawCard();
                        break;
                    case "Main Phase I":
                        //
                        whatToDo = mainPhaseI();
                        break;
                    case "Beginning of Combat":
                        //
                        whatToDo = beginningOfCombat();
                        break;
                    case "Declare Attackers":
                        //
                        whatToDo = TheirDeclareAttackers();
                        break;
                    case "Declare Blockers":
                        //
                        whatToDo = OurDeclareBlockers();
                        break;
                    case "Combat Damage":
                        //
                        whatToDo = combatDamage();
                        break;
                    case "End of Combat":
                        //
                        whatToDo = endOfCombat();
                        break;
                    case "Main Phase II":
                        //
                        whatToDo = mainPhaseII();
                        break;
                    case "End Step":
                        //
                        whatToDo = endStep();
                        break;
                    case "Cleanup":
                        //
                        whatToDo = cleanUp();
                        break;
                }


            }
            MessageBox.Show("" + whatToDo);
        }

        #endregion

        private void stageCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentGameState.CurrentGameState = (Convert.ToString(stageCB.Items[stageCB.SelectedIndex]));
        }

        private void turnCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // students can choose to implement this and add it to the current game state
            // MessageBox.Show("Students can choose to implement this and add it to the current game state.");
        }


        #region Rules

        private string TakeMulligan()
        {
            if (currentGameState.MyHand.Count() <= 5)
            {
                return "Accept Hand";
            }

            //If white keep 2 mana
            if (currentGameState.MyHand.Where(c => c.GetType() == typeof(Land)).Count() < 3 && !(currentGameState.MyHand.Count() <= 6))
            {
                currentGameState.MulliganCount++;
                currentGameState.MyHand.Clear();
                return string.Format("Take Mulligan. Draw {0} cards", 7 - currentGameState.MulliganCount);
            }

            if (currentGameState.MyHand.Where(c => c.GetType() == typeof(Land)).Count() == currentGameState.MyHand.Count())
            {
                currentGameState.MulliganCount++;
                currentGameState.MyHand.Clear();
                return string.Format("Take Mulligan. Draw {0} cards", 7 - currentGameState.MulliganCount);
            }

            var manaCount = currentGameState.MyHand.Where(c => c.GetType() == typeof(Land)).Count();
            var cardsCanPlay = new List<ICard>();

            foreach (ICard card in currentGameState.MyHand)
            {
                var manaCost = card.GreenCost + card.RedCost + card.WhiteCost + (card.ColorlessCost - 1);

                if (manaCost < manaCount)
                {
                    cardsCanPlay.Add(card);
                }
            }

            if (cardsCanPlay.Count == 0)
            {
                currentGameState.MulliganCount++;
                currentGameState.MyHand.Clear();
                return string.Format("Take Mulligan. Draw {0} cards", 7 - currentGameState.MulliganCount);
            }

            return "Accept Hand";
        }

        private string upTap()
        {
            //For all cards that are currently tapped - untap
            currentGameState.MyCreatures.ForEach(c => { c.IsSick = false; c.IsTapped = false; });

            if(myTurnCB.Checked)
            {
                var whatToDo = new StringBuilder();
                whatToDo.Append("Untap All cards");
                return whatToDo.ToString();
            }

            return "Do Nothing";
            
        }

        private string upKeep()
        {
            return "Do Nothing";
        }

        private string drawCard()
        {
            var whatToDo = new StringBuilder();

            if (turnCB.SelectedItem.ToString() == "1" && myTurnCB.Checked)
            {
                whatToDo.Append("Pass");
            }
            else if (opponentsTurnCB.Checked)
            {
                whatToDo.Append("Pass");
            }
            else
            {
                whatToDo.Append("Draw a Card");
            }

            return whatToDo.ToString();
        }

        private string mainPhaseI()
        {
            var whatToDo = new StringBuilder();

            if(opponentsTurnCB.Checked)
            {
                return "Do Nothing";
            }

            int manaCount = 0;
            int plainsCount = 0;
            int forestsCount = 0;

            if (knightsRB.Checked)
            {                
                plainsCount = currentGameState.myPlains;
                forestsCount = currentGameState.myForests;

                manaCount = plainsCount + forestsCount;
            }
            else if (dragonsRB.Checked)
            {
                manaCount = currentGameState.myMountains;
            }

            if(!currentGameState.PlayedLand)
            {
                if (currentGameState.MyHand.Any(c => c.ToString() == "Mountain"))
                {
                    whatToDo.Append("Play 1 Mountain");
                    currentGameState.PlayedLand = true;
                }
                if (currentGameState.MyHand.Any(c => c.ToString() == "Treetop Village"))
                {
                    whatToDo.Append("Play 1 Treetop Village");
                    currentGameState.PlayedLand = true;
                }
                else if (currentGameState.MyHand.Any(c => c.ToString() == "Plains") || currentGameState.MyHand.Any(c => c.ToString() == "Forest"))
                {
                    if ((currentGameState.myPlains == 0 || currentGameState.myPlains < currentGameState.myForests + 1) || currentGameState.MyHand.Any(c => c.ToString() == "Plains"))
                    {
                        whatToDo.Append("Play 1 Plains");
                        currentGameState.PlayedLand = true;
                    }
                    else if (currentGameState.myForests < currentGameState.myPlains && currentGameState.MyHand.Any(c => c.ToString() == "Forest"))
                    {
                        whatToDo.Append("Play 1 Forest");
                        currentGameState.PlayedLand = true;
                    }
                }
            }            

            if (currentGameState.MyHand.FirstOrDefault(c => c.ToString() == "Cinder Wall") != null && manaCount >= 1)
            {
                whatToDo.Append("Tap 1 Mountain and play Cinder Wall");
                manaCount = manaCount - 1;
                currentGameState.myMountains--;
            }

            // -------------  Implement when we have a statement if a land card has already been played this turn or not ----------------------
            //if (currentGameState.MyHand.FirstOrDefault(c => c.ToString() == "Treetop Village") != null)
            //{
            //    whatToDo.Append("Play Treetop Village and add a forest to the deck");
            //}

            // Heroes' Reunion
            //implement a manacost check when mana is added-------------------------------------------------------------------------
            if (currentGameState.MyHand.FirstOrDefault(c => c.ToString() == "Heroes' Reunion") != null && currentGameState.myForests >= 1 && currentGameState.myPlains >= 1
                || currentGameState.mySelesnyaSanctuary >= 1)
            {
                if (currentGameState.mySelesnyaSanctuary >= 1)
                {
                    whatToDo.Append("Tap 1 Selesnya Sanctuary and play Heroes' Reunion");
                }
                else
                {
                    whatToDo.Append("Tap 1 Plains and 1 Forest and play Heroes' Reunion targeting yourself");
                    manaCount += 1;
                    currentGameState.myPlains--;
                    currentGameState.myForests--;
                }
            }

            var Reprisal = new Instant();
            Reprisal = currentGameState.KnightInstants.Where(c => c.CardName == "Reprisal").FirstOrDefault();
            if (Reprisal != null && currentGameState.OpponentCreatures.Count != 0 && currentGameState.OpponentCreatures.Any(c => c.Power >= 4))
            {
                var targetCreature = currentGameState.OpponentCreatures.OrderByDescending(c => c.Power).FirstOrDefault();

                if (plainsCount > 1)
                {
                    whatToDo.Append(string.Format("Tap 2 Plains and Play {0} targeting {1}", Reprisal.ToString(), targetCreature.ToString()));
                    manaCount = manaCount - 2;
                    currentGameState.myPlains -= 2;                    
                }
                else if (currentGameState.mySelesnyaSanctuary > 1)
                {
                    whatToDo.Append(string.Format("Tap 1 Selesnya Sanctuary and Play {0} targeting {1}", Reprisal.ToString(), targetCreature.ToString()));
                }
                else if (plainsCount == 1 && forestsCount >= 1)
                {
                    whatToDo.Append(string.Format("Tap 1 Plains and 1 Forest and {0} targeting {1}", Reprisal.ToString(), targetCreature.ToString()));
                    manaCount = manaCount - 2;
                    currentGameState.myPlains--;
                    currentGameState.myForests--;
                }
            }

            var cardsCanPlay = currentGameState.MyHand.Where(c => c.TotalManaCost <= manaCount).ToList();
            var creaturesCanPlay = cardsCanPlay.Where(c => c is Creature).OrderByDescending(c => c.TotalManaCost);

            foreach (ICard card in creaturesCanPlay)
            {
                var manaCost = card.TotalManaCost;


                Creature c = (Creature)card;

                if (manaCost <= manaCount)
                {
                    if (knightsRB.Checked)
                    {
                        if (c.GreenCost <= forestsCount && c.WhiteCost <= plainsCount
                            && c.ColorlessCost <= (manaCount - (c.GreenCost + c.WhiteCost)))
                        {
                            if (c.ColorlessCost <= (forestsCount - c.GreenCost))
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2}", c.GreenCost + c.ColorlessCost, c.WhiteCost, c.ToString()));
                                currentGameState.myForests = currentGameState.myForests - (c.GreenCost - c.ColorlessCost);
                                currentGameState.myPlains = currentGameState.myPlains - c.WhiteCost;
                                manaCount = manaCount - c.TotalManaCost;
                                
                            }
                            else if (c.ColorlessCost <= (plainsCount - c.WhiteCost))
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2}", c.GreenCost, c.WhiteCost + c.ColorlessCost, c.ToString()));
                                currentGameState.myForests = currentGameState.myForests - c.GreenCost;
                                currentGameState.myPlains = currentGameState.myPlains - (c.WhiteCost - c.ColorlessCost);
                                manaCount = manaCount - c.TotalManaCost;
                                
                            }
                            else if (manaCost == manaCount)
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2}", forestsCount, plainsCount, c.ToString()));
                                currentGameState.myForests = 0;
                                currentGameState.myPlains = 0;
                                manaCount = 0;
                                
                            }
                        }
                    }
                    else if (dragonsRB.Checked)
                    {
                        whatToDo.Append(string.Format("Tap {0} Mountains and play {1}", c.RedCost + c.ColorlessCost, c.ToString()));
                        manaCount = manaCount - (c.TotalManaCost);
                        currentGameState.myMountains -= c.TotalManaCost;
                        
                    }
                }
            }

            var instantsCanPlay = cardsCanPlay.Where(c => c is Instant).OrderByDescending(c => c.TotalManaCost);

            foreach(ICard card in instantsCanPlay)
            {
                var manaCost = card.TotalManaCost;

                Instant i = (Instant)card;

                if (manaCost <= manaCount && i.ToString() != "Test of Faith")
                {
                    var targetString = GetTarget(i.ToString());

                    if(targetString == "")
                    {
                        continue;
                    }

                    if (knightsRB.Checked)
                    {
                        if (i.GreenCost <= forestsCount && i.WhiteCost <= plainsCount
                            && i.ColorlessCost <= (manaCount - (i.GreenCost + i.WhiteCost)))
                        {
                            if (i.ColorlessCost <= (forestsCount - i.GreenCost))
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2} {3}", i.GreenCost + i.ColorlessCost, i.WhiteCost, i.ToString(), targetString));
                                currentGameState.myForests = currentGameState.myForests - (i.GreenCost - i.ColorlessCost);
                                currentGameState.myPlains = currentGameState.myPlains - i.WhiteCost;
                                manaCount = manaCount - i.TotalManaCost;
                            }
                            else if (i.ColorlessCost <= (plainsCount - i.WhiteCost))
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2} {3}", i.GreenCost, i.WhiteCost + i.ColorlessCost, i.ToString(), targetString));
                                currentGameState.myForests = currentGameState.myForests - i.GreenCost;
                                currentGameState.myPlains = currentGameState.myPlains - (i.WhiteCost - i.ColorlessCost);
                                manaCount = manaCount - i.TotalManaCost;
                            }
                            else if (manaCost == manaCount)
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2} {3}", forestsCount, plainsCount, i.ToString(), targetString));
                                currentGameState.myForests = 0;
                                currentGameState.myPlains = 0;
                                manaCount = 0;
                            }
                        }
                    }
                    else if (dragonsRB.Checked)
                    {
                        whatToDo.Append(string.Format("Tap {0} Mountains and play {1} {2}", i.RedCost + i.ColorlessCost, i.ToString(), targetString));
                        manaCount = manaCount - (i.TotalManaCost);
                        currentGameState.myMountains -= i.TotalManaCost;
                    }
                }
            }

            var enchantmentCanPlay = cardsCanPlay.Where(c => c is Enchantment).OrderByDescending(c => c.TotalManaCost);

            foreach(ICard card in enchantmentCanPlay)
            {
                var manaCost = card.TotalManaCost;

                Enchantment e = (Enchantment)card;

                if (manaCost <= manaCount)
                {
                    var targetString = GetTarget(e.ToString());

                    if(targetString == "")
                    {
                        continue;
                    }
                    if (knightsRB.Checked)
                    {
                        if (e.GreenCost <= forestsCount && e.WhiteCost <= plainsCount
                            && e.ColorlessCost <= (manaCount - (e.GreenCost + e.WhiteCost)))
                        {
                            if (e.ColorlessCost <= (forestsCount - e.GreenCost))
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2} {3}", e.GreenCost + e.ColorlessCost, e.WhiteCost, e.ToString(), targetString));
                                currentGameState.myForests = currentGameState.myForests - (e.GreenCost - e.ColorlessCost);
                                currentGameState.myPlains = currentGameState.myPlains - e.WhiteCost;
                                manaCount = manaCount - e.TotalManaCost;
                            }
                            else if (e.ColorlessCost <= (plainsCount - e.WhiteCost))
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2} {3}", e.GreenCost, e.WhiteCost + e.ColorlessCost, e.ToString(), targetString));
                                currentGameState.myForests = currentGameState.myForests - e.GreenCost;
                                currentGameState.myPlains = currentGameState.myPlains - (e.WhiteCost - e.ColorlessCost);
                                manaCount = manaCount - e.TotalManaCost;
                            }
                            else if (manaCost == manaCount)
                            {
                                whatToDo.Append(string.Format("Tap {0} Forests and {1} Plains to play {2} {3}", forestsCount, plainsCount, e.ToString(), targetString));
                                currentGameState.myForests = 0;
                                currentGameState.myPlains = 0;
                                manaCount = 0;
                            }
                        }
                    }
                    else if (dragonsRB.Checked)
                    {
                        whatToDo.Append(string.Format("Tap {0} Mountains and play {1} {2}", e.RedCost + e.ColorlessCost, e.ToString(), targetString));
                        manaCount = manaCount - (e.TotalManaCost);
                        currentGameState.myMountains -= e.TotalManaCost;
                    }
                }
            }

            return whatToDo.ToString();
        }        

        private string GetTarget(string cardName)
        {
            switch(cardName)
            {
                case "Edge of Autumn":
                    return "targeting Yourself";
                case "Griffin Guide":
                    var griffinGuideCreatures = currentGameState.MyCreatures.Where(c => c.Flying != 1).OrderByDescending(c => c.Power).FirstOrDefault();
                    if(griffinGuideCreatures == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", griffinGuideCreatures.ToString()); 
                    }                                   
                case "Oblivion Ring":
                    var oblivionRingTargets = currentGameState.OpponentCreatures.OrderByDescending(c => c.Power).FirstOrDefault();
                    if(oblivionRingTargets == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", oblivionRingTargets.ToString());
                    }                    
                case "Spidersilk Armor":
                    var spidersilkTargets = currentGameState.MyCreatures.Where(c => c.Flying != 1).OrderBy(c => c.Power).FirstOrDefault();
                    if(spidersilkTargets == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", spidersilkTargets.ToString());
                    }             
                                
                case "Mighty Leap":
                    var mightyLeapTarget = currentGameState.MyCreatures.Where(c => c.Flying != 1).OrderByDescending(c => c.Power).FirstOrDefault();
                    if(mightyLeapTarget == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", mightyLeapTarget.ToString());
                    }                 
                
                case "Sigil Blessing":
                    var sigilBlessingTargets = currentGameState.MyCreatures.OrderByDescending(c => c.Power);
                    if(sigilBlessingTargets == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0} for +3/+3 and the rest of your creature for +1/+1", sigilBlessingTargets.First().ToString());
                    }                 
                                
                case "Captive Flame":
                    var captiveFlameTargets = currentGameState.MyCreatures.OrderByDescending(c => c.Power).FirstOrDefault();
                    if(captiveFlameTargets == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", captiveFlameTargets.ToString());
                    }
                    
                case "Claws of Valakut":
                    var clawsTarget = currentGameState.MyCreatures.OrderByDescending(c => c.Power).FirstOrDefault();
                    if(clawsTarget == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", clawsTarget.ToString());
                    }
                    
                case "Cone of Flame":
                    var coneTargets = currentGameState.OpponentCreatures.OrderByDescending(c => c.Power);
                    if(coneTargets == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targetin opponent for 3 damage, {0} for 2 damage, and {1} for 1 damage", coneTargets.First().ToString(), coneTargets.Skip(1).First().ToString());
                    }
                    
                case "Dragon Fodder":
                    return "targeting yourself";
                case "Jaws of Stone":
                    return "targeting opponent";
                case "Shiv's Embrace":
                    var shivTargets = currentGameState.MyCreatures.Where(c => c.Flying != 1).OrderByDescending(c => c.Power).FirstOrDefault();
                    if(shivTargets == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", shivTargets.ToString());
                    }
                    
                case "Spitting Earth":
                    var spittingTarget = currentGameState.OpponentCreatures.OrderByDescending(c => c.Power).FirstOrDefault();
                    if(spittingTarget == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", spittingTarget);
                    }
                    
                case "Temporary Insanity":
                    var tempTarget = currentGameState.OpponentCreatures.OrderByDescending(c => c.ToString()).FirstOrDefault();
                    if(tempTarget == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", tempTarget.ToString());
                    }
                    
                case "Fiery Fall":
                    var fieryTarget = currentGameState.OpponentCreatures.OrderByDescending(c => c.ToString()).FirstOrDefault();
                    if(fieryTarget == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", fieryTarget.ToString());
                    }
                    
                case "Ghostfire":

                    return "targeting opponent";
                case "Punishing Fire":
                    return "targeting opponent";                
                case "Seismic Strike":
                    var seismicTarget = currentGameState.OpponentCreatures.OrderByDescending(c => c.ToString()).FirstOrDefault();
                    if(seismicTarget == null)
                    {
                        return "";
                    }
                    else
                    {
                        return string.Format("targeting {0}", seismicTarget);
                    } 
                default:
                    return "";
            }            
        }

        private string beginningOfCombat()
        {
            var whatToDo = new StringBuilder();

            whatToDo.Append("Do Nothing");

            return whatToDo.ToString();
        }

        private string OurDeclareAttackers()
        {
            var whatToDo = new StringBuilder();

            //win condition??
            //PWN NOOB CONDITION!!
            if(currentGameState.MyCreatures.Count > 0)
            {
                foreach(var creature in currentGameState.MyCreatures.Where(c => !c.IsSick))
                {
                    return string.Format("Attack with {0}", creature.ToString());
                }
                
            }

            return "Don't Attack";
            //if (currentGameState.MyCreatures.Sum(c => c.Power) >= currentGameState.OpponentLife || currentGameState.OpponentCreatures.Count == 0)
            //{
            //    foreach (var creature in currentGameState.MyCreatures.Where(c => !c.IsSick && !c.IsTapped))
            //    {
            //        whatToDo.Append(string.Format("Attack with {0}", creature.ToString()));
            //    }

            //    currentGameState.MyCreatures.ForEach(c => { c.IsTapped = true; });
            //}

            //var protectionFromRed = new Creature();
            //protectionFromRed = currentGameState.MyCreatures.Where(c => c.ProtectionFromRed == 1 && !c.IsSick && !c.IsTapped).FirstOrDefault();
            //if (protectionFromRed != null)
            //{
            //    whatToDo.Append(string.Format("Attack with {0}", protectionFromRed.ToString()));
            //    protectionFromRed.IsTapped = true;
            //}

            ////If we have flyers and they do cannot defend
            //if (currentGameState.OpponentCreatures.Sum(c => c.Flying) == 0)
            //{
            //    var flyingCreatures = currentGameState.MyCreatures.Where(c => c.Flying == 1 && !c.IsSick && !c.IsTapped).ToList();

            //    if (flyingCreatures.Count != 0)
            //    {
            //        whatToDo.Append("Attack with: ");
            //        flyingCreatures.ForEach(c => { whatToDo.Append(c.ToString()); });
            //    }

            //    flyingCreatures.ForEach(c => { c.IsTapped = true; });
            //}

            return whatToDo.ToString();
        }

        private string TheirDeclareAttackers()
        {
            return "Do Nothing";
        }

        private string OurDeclareBlockers()
        {
            var whatToDo = new StringBuilder();

            if (myTurnCB.Checked)
            {
                whatToDo.Append("Skip this phase");
                return whatToDo.ToString();
            }
            else
            {
                if (currentGameState.MyLife < 12 && currentGameState.MyCreatures.Where(c => c.IsTapped != true).Count() > 0)
                {
                    whatToDo.Append("Block");
                    return whatToDo.ToString();
                }

                whatToDo.Append("Skip this phase");
                return whatToDo.ToString();
            }
        }        

        private string combatDamage()
        {
            return "Asses Combat Damage";
        }

        private string endOfCombat()
        {
            return "Do Nothing, Continue";
        }

        private string mainPhaseII()
        {
            return "Do Nothing, Continue";
        }

        private string endStep()
        {
            return "Continue to Cleanup";
        }

        private string cleanUp()
        {
            //If cards are less than 7 draw one
            if (currentGameState.MyCreatures.Count > 7)
            {
                var hand = currentGameState.MyHand;
                //No idea how to sort by power....
                var cardToDiscard = hand.OrderByDescending(c => c.TotalManaCost).FirstOrDefault();

                return string.Format("Discard {0}", cardToDiscard.ToString());
            }

            currentGameState.MyCreatures.All(c => c.IsSick = false);

            currentGameState.myMountains = (int)myMountainCounter.Value;
            currentGameState.myPlains = (int)myPlainsCounter.Value;
            currentGameState.myForests = (int)myForestCounter.Value;

            currentGameState.PlayedLand = false;

            if(myTurnCB.Checked)
            {
                return "Pass turn to Opponent";
            }

            return "Your Turn";
            
        }


        #endregion

        private void myOpponentGrasslandsCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.myGrasslands = (int)myGrasslandsCounter.Value;
        }

        private void myGrasslandsCounter_ValueChanged(object sender, EventArgs e)
        {
            currentGameState.opponentGrasslands = (int)myOpponentGrasslandsCounter.Value;
        }

        private void opponentsTurnCB_CheckedChanged(object sender, EventArgs e)
        {
            myTurnCB.Checked = false;
        }

        private void myTurnCB_CheckedChanged(object sender, EventArgs e)
        {
            opponentsTurnCB.Checked = false;
        }

        private void addCardHandButton_Click(object sender, EventArgs e)
        {
            addToHandForm a2h = new addToHandForm(currentGameState);

            a2h.ShowDialog();

            if (a2h.GetCardToAdd() != null)
            {
                currentGameState.MyHand.Add((a2h.GetCardToAdd()));
            }
            else
            {
                // If it's null, it may be that they just cancelled out of it, if so, we just won't add it
            }
        }

        private void removeCardFromHandButton_Click(object sender, EventArgs e)
        {
            if (currentGameState.MyHand.Count > 0)
            {
                removeFromHandForm rfh = new removeFromHandForm(currentGameState.MyHand);

                rfh.ShowDialog();

                if (rfh.getCardToRemove() != null)
                {
                    currentGameState.MyHand.Remove((rfh.getCardToRemove()));
                }
                else
                {
                    // If it's null, it may be that they just cancelled out of it, if so, we just won't add it
                }
            }
            else
            {
                MessageBox.Show("No cards currently in hand");
            }
        }
    }
}
