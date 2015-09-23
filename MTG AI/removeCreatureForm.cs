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
    public partial class removeCreatureForm : Form
    {
        private List<Creature> CreatureList;

        private Creature CreatureToRemove;

        public Creature getCreatureToRemove()
        {
            return CreatureToRemove;
        }

        public removeCreatureForm(List<Creature> CreaturesInPlay)
        {
            InitializeComponent();
            CreatureList = new List<Creature>(CreaturesInPlay);

            // initialize our listbox
            foreach (Creature c in CreatureList)
            {
                CreatureCB.Items.Add(c.ToString());
            }

            CreatureCB.SelectedIndex = 0;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            CreatureToRemove = CreatureList[CreatureCB.SelectedIndex];
            this.Close();
        }

        private void removeCreatureForm_Load(object sender, EventArgs e)
        {

        }
    }
}
