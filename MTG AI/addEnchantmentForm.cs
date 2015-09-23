/*--------------------------------------------------------------------------------------
*  Written by: Denny Bobeldyk Summer 2013
*  Modified by: <insert your name here>
*  
*  Possible future improvements:
* --------------------------------------------------------------------------------------*/

// In theory you could enchant someone else's Creatures, so would need to pass the whole game state? or just dissallow that for now
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MTG_AI.DTO_s;

namespace MTG_AI
{
    public partial class addEnchantmentForm : Form
    {       

        // Knights vs. Dragons enchantments      
        private List<Creature> CreatureList;
        private List<Enchantment> EnchantmentList;

        private List<Enchantment> _creatureEnchantments = new List<Enchantment>();
        private List<Enchantment> _globalEnchantments = new List<Enchantment>();

        private Creature CreatureToEnchant;
        private Enchantment enchantment;
        private gameState currentGameState;        

        public addEnchantmentForm()
        {
            InitializeComponent();
        }

        // Can make this fancier and if we dont have any Creatures in play, only list the global enchantments
        public addEnchantmentForm(gameState currentGameState, List<Creature> CreaturesInPlay)
        {
            InitializeComponent();
            this.currentGameState = currentGameState;

            EnchantmentList = new List<Enchantment>();

            foreach(var enchantment in currentGameState.AllEnchantments)
            {
                enchantmentCB.Items.Add(enchantment.ToString());

                if(enchantment.GlobalEnchantment == 1)
                {
                    _globalEnchantments.Add(enchantment);
                }
                else
                {
                    _creatureEnchantments.Add(enchantment);
                }
            }            

            //enchantmentCB.SelectedIndex = 0;

            CreatureList = new List<Creature>(CreaturesInPlay);

            // initialize our listbox
            if (CreaturesInPlay.Count > 0)
            {
                foreach (Creature c in CreatureList)
                {
                    CreatureCB.Items.Add(c.ToString());
                }
                CreatureCB.SelectedIndex = 0; // this will error if there are no Creatures in play
            }
        }        

        private void enchantmentCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (enchantmentCB.SelectedIndex >= _creatureEnchantments.Count())
            //{
            //    CreatureCB.Enabled = false;                
            //}
            //else
            //{
            //    CreatureCB.Enabled = true;                
            //}
        }

        // If it's a Creature enchantment, we can add it right here, otherwise, we need to add the global enchantment from the method that calls us
        private void addButton_Click(object sender, EventArgs e)
        {
            Enchantment selectedEnchantment = new Enchantment();
            selectedEnchantment = (Enchantment)currentGameState.AllEnchantments.Where(en => en.CardName == enchantmentCB.SelectedItem.ToString()).FirstOrDefault();
            if (_globalEnchantments.Contains(selectedEnchantment))
            {
                CreatureToEnchant = null;
                enchantment = selectedEnchantment;
            }
            else
            {
                CreatureToEnchant = CreatureList[CreatureCB.SelectedIndex];
                enchantment = (Enchantment)currentGameState.AllEnchantments.Where(en => en.CardName == enchantmentCB.SelectedItem.ToString()).FirstOrDefault();

                CreatureToEnchant.CreatureEnchantments.Add(selectedEnchantment);                
            }
            this.Close();
        }

        public Enchantment GetEnchantment()
        {
            return enchantment;
        }
    }
}
