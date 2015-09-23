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
    public partial class addToHandForm : Form
    {
        private ICard cardToAdd;
        private gameState currentGameState;        

        public addToHandForm(gameState currentGameState)
        {
            InitializeComponent();
            
            this.currentGameState = currentGameState;
        }       

        private void addButton_Click(object sender, EventArgs e)
        {
            // Should probably do something different here           
            try
            {
                if (knightsRB.Checked)
                {
                    cardToAdd = (ICard)currentGameState.KnightCards.Where(c => c.ToString() == addToHandCB.SelectedItem.ToString()).FirstOrDefault();                    
                }
                else if (dragonsRB.Checked)
                {
                    cardToAdd = (ICard)currentGameState.DragonCards.Where(c => c.ToString() == addToHandCB.SelectedItem.ToString()).FirstOrDefault();
                }

                this.Close(); 
            }      
            catch
            {

            }
        }

        public ICard GetCardToAdd()
        {
            return cardToAdd;
        }

        private void addToHandForm_Load(object sender, EventArgs e)
        {
            if(knightsRB.Checked)
            {
                foreach(var card in currentGameState.KnightCards)
                {
                    addToHandCB.Items.Add(card.ToString());
                }
            }
            else
            {
                foreach(var card in currentGameState.DragonCards)
                {
                    addToHandCB.Items.Add(card.ToString());
                }
            }
        }

        private void knightsRB_CheckedChanged(object sender, EventArgs e)
        {
            addToHandCB.Items.Clear();
            foreach (var card in currentGameState.KnightCards)
            {
                addToHandCB.Items.Add(card.ToString());
            }
        }

        private void dragonsRB_CheckedChanged(object sender, EventArgs e)
        {
            addToHandCB.Items.Clear();
            foreach (var card in currentGameState.DragonCards)
            {
                addToHandCB.Items.Add(card.ToString());
            }
        }
    }
}
