/*--------------------------------------------------------------------------------------
*  Written by: Denny Bobeldyk Summer 2013
*  Modified by: <insert your name here>
*  
*  Possible future improvements:
*     Pass the gamestate and check to see what they can cast based on open mana, or even check to see what deck they're playing
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

namespace MTG_AI{

    public partial class addCreatureForm : Form
    {
        private Creature CreatureToAdd;
        public gameState currentGameState;      
        

        public addCreatureForm(gameState currentGameState)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.currentGameState = currentGameState;            
        }

        public Creature getCreatureToAdd()
        {
            CreatureToAdd.IsSick = true;
            return CreatureToAdd;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addCreatureCB.Items.Count > 0)
            {         
                if(knightsRB.Checked)
                {
                    CreatureToAdd = (Creature)currentGameState.KnightCreatures.Where(c => c.CardName == addCreatureCB.SelectedItem.ToString()).FirstOrDefault();

                    this.Close();  
                }
                else
                {
                    CreatureToAdd = (Creature)currentGameState.DragonCreatures.Where(c => c.CardName == addCreatureCB.SelectedItem.ToString()).FirstOrDefault();
                    this.Close();
                }                      
            }            
        }

        private void addCreatureForm_Load(object sender, EventArgs e)
        {
            addCreatureCB.Items.Clear();

            if(knightsRB.Checked)
            {
                foreach(var creature in currentGameState.KnightCreatures)
                {
                    addCreatureCB.Items.Add(creature.ToString());
                }
            }
            else
            {
                foreach (var creature in currentGameState.DragonCreatures)
                {
                    addCreatureCB.Items.Add(creature.ToString());
                }
            }
        }
    }
}
