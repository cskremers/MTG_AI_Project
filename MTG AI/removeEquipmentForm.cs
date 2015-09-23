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
    public partial class removeEquipmentForm : Form
    {
        // Not happy with the names here
        private List<Creature> CreatureList;
        private List<Equipment> equipmentList;

        private void removeEquipmentFromCreatureButton_Click(object sender, EventArgs e)
        {
            // only need to worry about one piece of equipment
            //CreatureList[CreatureCB.SelectedIndex].removeEquipment("Loxodon Warhammer");
            this.Close();

        }

        private void removeEquipmentButton_Click(object sender, EventArgs e)
        {
            // only need to worry about one piece of equipment
            equipmentList.Clear(); // This isn't working for some reason

            this.Close();
        }

        public removeEquipmentForm(List<Creature> Creatures, List<Equipment> equipment)
        {
            InitializeComponent();

            CreatureList = Creatures;
            equipmentList = equipment;

            foreach (Creature c in Creatures)
            {
                CreatureCB.Items.Add(c.ToString());
            }

            if (Creatures.Count > 0)
            {
                CreatureCB.SelectedIndex = 0;
            }
            else
            {
                CreatureCB.Enabled = false;
                removeEquipmentFromCreatureButton.Enabled = false;
            }


            foreach (var e in equipment)
            {
                equipmentCB.Items.Add(e.ToString());
            }

            if (equipment.Count > 0)
            {
                equipmentCB.SelectedIndex = 0;
            }
            else
            {
                equipmentCB.Enabled = false;
                removeEquipmentButton.Enabled = false;
            }
        }
    }
}
