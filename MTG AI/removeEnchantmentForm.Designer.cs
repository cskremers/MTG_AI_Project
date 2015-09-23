namespace MTG_AI
{
    partial class removeEnchantmentForm
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
            this.enchantmentsCB = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enchantmentsCB
            // 
            this.enchantmentsCB.FormattingEnabled = true;
            this.enchantmentsCB.Location = new System.Drawing.Point(28, 52);
            this.enchantmentsCB.Name = "enchantmentsCB";
            this.enchantmentsCB.Size = new System.Drawing.Size(317, 21);
            this.enchantmentsCB.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(387, 52);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeEnchantmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 128);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.enchantmentsCB);
            this.Name = "removeEnchantmentForm";
            this.Text = "Remove Enchantment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox enchantmentsCB;
        private System.Windows.Forms.Button removeButton;

    }
}