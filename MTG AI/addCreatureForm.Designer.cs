namespace MTG_AI
{
    partial class addCreatureForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.knightsRB = new System.Windows.Forms.RadioButton();
            this.dragonsRB = new System.Windows.Forms.RadioButton();
            this.addCreatureCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(304, 55);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Creature to Add:";
            // 
            // knightsRB
            // 
            this.knightsRB.AutoSize = true;
            this.knightsRB.Checked = true;
            this.knightsRB.Location = new System.Drawing.Point(13, 13);
            this.knightsRB.Name = "knightsRB";
            this.knightsRB.Size = new System.Drawing.Size(60, 17);
            this.knightsRB.TabIndex = 4;
            this.knightsRB.TabStop = true;
            this.knightsRB.Text = "Knights";
            this.knightsRB.UseVisualStyleBackColor = true;
            this.knightsRB.CheckedChanged += new System.EventHandler(this.addCreatureForm_Load);
            // 
            // dragonsRB
            // 
            this.dragonsRB.AutoSize = true;
            this.dragonsRB.Location = new System.Drawing.Point(79, 13);
            this.dragonsRB.Name = "dragonsRB";
            this.dragonsRB.Size = new System.Drawing.Size(65, 17);
            this.dragonsRB.TabIndex = 5;
            this.dragonsRB.Text = "Dragons";
            this.dragonsRB.UseVisualStyleBackColor = true;
            this.dragonsRB.CheckedChanged += new System.EventHandler(this.addCreatureForm_Load);
            // 
            // addCreatureCB
            // 
            this.addCreatureCB.FormattingEnabled = true;
            this.addCreatureCB.Location = new System.Drawing.Point(12, 55);
            this.addCreatureCB.Name = "addCreatureCB";
            this.addCreatureCB.Size = new System.Drawing.Size(286, 21);
            this.addCreatureCB.TabIndex = 6;
            // 
            // addCreatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 94);
            this.Controls.Add(this.addCreatureCB);
            this.Controls.Add(this.dragonsRB);
            this.Controls.Add(this.knightsRB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "addCreatureForm";
            this.Text = "Add Creature ";
            this.Load += new System.EventHandler(this.addCreatureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton knightsRB;
        private System.Windows.Forms.RadioButton dragonsRB;
        private System.Windows.Forms.ComboBox addCreatureCB;

    }
}