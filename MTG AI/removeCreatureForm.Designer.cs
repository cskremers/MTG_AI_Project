namespace MTG_AI
{
    partial class removeCreatureForm
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
            this.removeButton = new System.Windows.Forms.Button();
            this.CreatureCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(422, 42);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // CreatureCB
            // 
            this.CreatureCB.FormattingEnabled = true;
            this.CreatureCB.Location = new System.Drawing.Point(42, 42);
            this.CreatureCB.Name = "CreatureCB";
            this.CreatureCB.Size = new System.Drawing.Size(338, 21);
            this.CreatureCB.TabIndex = 2;
            // 
            // removeCreatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 116);
            this.Controls.Add(this.CreatureCB);
            this.Controls.Add(this.removeButton);
            this.Name = "removeCreatureForm";
            this.Text = "Remove Creature";
            this.Load += new System.EventHandler(this.removeCreatureForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ComboBox CreatureCB;

    }
}