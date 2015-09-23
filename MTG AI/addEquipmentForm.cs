/*--------------------------------------------------------------------------------------
*  Written by: Denny Bobeldyk Summer 2013
*  Modified by: <insert your name here>
*  
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

namespace MTG_AI
{
    public partial class addEquipmentForm : Form
    {
        // Just one for this duel deck, but leaving it open for others        

        private List<Creature> CreatureList;

        private Creature CreatureToEquip = null;
        private Equipment equipment = null;
        private gameState currentGameState;        

        public addEquipmentForm(gameState currentGameState, List<Creature> CreaturesInPlay)
        {
            InitializeComponent();

            CreatureList = CreaturesInPlay;

            foreach (var equipment in currentGameState.Equipment)
            {
                equipmentCB.Items.Add(equipment.ToString());
            }
            equipmentCB.SelectedIndex = 0;

            foreach (Creature c in CreaturesInPlay)
            {
                CreatureCB.Items.Add(c.ToString());
            }

            if (CreaturesInPlay.Count > 0)
            {
                CreatureCB.SelectedIndex = 0;
            }

            equipCreatureCheckBox.Checked = false;
            CreatureCB.Enabled = false;
        }        

        private void addEquipmentButton_Click(object sender, EventArgs e)
        {
            equipment = (Equipment)currentGameState.Equipment.Where(eq => eq.CardName == equipmentCB.SelectedItem.ToString());


            if (equipCreatureCheckBox.Checked)
            {
                CreatureToEquip = CreatureList[CreatureCB.SelectedIndex];
                CreatureToEquip.CreatureEquipment.Add(equipment); // this does work from here
            }
           
            this.Close();
        }

        private void equipCreatureCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (equipCreatureCheckBox.Checked)
            {
                if (CreatureList.Count > 0)
                {
                    CreatureCB.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No Creatures in play to add to");
                    equipCreatureCheckBox.Checked = false;
                }
            }
            else
            {
                CreatureCB.Enabled = false;
            }
        }

        public Equipment GetEquipment()
        {
            return equipment;
        }

        public Creature GetCreature()
        {
            return CreatureToEquip;
        }
    }
}
