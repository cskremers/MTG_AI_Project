/*--------------------------------------------------------------------------------------
*  Written by: Denny Bobeldyk Summer 2013
*  Modified by: <insert your name here>
*  
* --------------------------------------------------------------------------------------*/

// No disenchants in this deck, so no need to worry about that.

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
    public partial class removeEnchantmentForm : Form
    {
        List<Enchantment> enchantments;
        Enchantment enchantmentToRemove;

        public removeEnchantmentForm(List<Enchantment> enchantmentsInPlay)
        {
            if (enchantmentsInPlay.Count == 0)
            {
                // shouldn't exit immediately if no enchantments passed to us
                this.Close();
            }

            InitializeComponent();

            enchantments = enchantmentsInPlay;

            foreach (var enchantment in enchantmentsInPlay)
            {
                enchantmentsCB.Items.Add(enchantment.ToString());
            }

            enchantmentsCB.SelectedIndex = 0;
        }

        public Enchantment getEnchantmentToRemove()
        {
            return enchantmentToRemove;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            enchantmentToRemove = enchantments[enchantmentsCB.SelectedIndex];
            enchantments.Remove(enchantments[enchantmentsCB.SelectedIndex]); // Maybe just do it right here?
            this.Close();
        }
    }
}
