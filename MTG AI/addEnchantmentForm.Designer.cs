namespace MTG_AI
{
    partial class addEnchantmentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enchantmentCB = new System.Windows.Forms.ComboBox();
            this.CreatureCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enchantmentCB
            // 
            this.enchantmentCB.FormattingEnabled = true;
            this.enchantmentCB.Location = new System.Drawing.Point(55, 67);
            this.enchantmentCB.Name = "enchantmentCB";
            this.enchantmentCB.Size = new System.Drawing.Size(190, 21);
            this.enchantmentCB.TabIndex = 0;
            this.enchantmentCB.SelectedIndexChanged += new System.EventHandler(this.enchantmentCB_SelectedIndexChanged);
            // 
            // CreatureCB
            // 
            this.CreatureCB.FormattingEnabled = true;
            this.CreatureCB.Location = new System.Drawing.Point(55, 140);
            this.CreatureCB.Name = "CreatureCB";
            this.CreatureCB.Size = new System.Drawing.Size(190, 21);
            this.CreatureCB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enchantment to Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creature to Enchant";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(58, 209);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(187, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add Enchantment";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addEnchantmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 277);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreatureCB);
            this.Controls.Add(this.enchantmentCB);
            this.Name = "addEnchantmentForm";
            this.Text = "Add Enchantment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox enchantmentCB;
        private System.Windows.Forms.ComboBox CreatureCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addButton;
    }
}