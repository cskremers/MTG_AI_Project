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
    public partial class removeFromHandForm : Form
    {
        private ICard cardToRemove;
        List<ICard> myCurrentHand;

        public removeFromHandForm(List<ICard> myHand)
        {
            InitializeComponent();

            myCurrentHand = myHand;

            // initialize our listbox
            foreach (var card in myHand)
            {
                removeFromHandCB.Items.Add(card.ToString());
            }

            removeFromHandCB.SelectedIndex = 0;
        }

        public ICard getCardToRemove()
        {
            return cardToRemove;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            cardToRemove = myCurrentHand[removeFromHandCB.SelectedIndex];
            this.Close();
        }
    }
}
