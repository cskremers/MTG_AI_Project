namespace MTG_AI
{
    partial class removeEquipmentForm
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
            this.CreatureCB = new System.Windows.Forms.ComboBox();
            this.removeEquipmentFromCreatureButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmentCB = new System.Windows.Forms.ComboBox();
            this.removeEquipmentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatureCB
            // 
            this.CreatureCB.FormattingEnabled = true;
            this.CreatureCB.Location = new System.Drawing.Point(12, 38);
            this.CreatureCB.Name = "CreatureCB";
            this.CreatureCB.Size = new System.Drawing.Size(337, 21);
            this.CreatureCB.TabIndex = 0;
            // 
            // removeEquipmentFromCreatureButton
            // 
            this.removeEquipmentFromCreatureButton.Location = new System.Drawing.Point(396, 38);
            this.removeEquipmentFromCreatureButton.Name = "removeEquipmentFromCreatureButton";
            this.removeEquipmentFromCreatureButton.Size = new System.Drawing.Size(75, 23);
            this.removeEquipmentFromCreatureButton.TabIndex = 1;
            this.removeEquipmentFromCreatureButton.Text = "Remove";
            this.removeEquipmentFromCreatureButton.UseVisualStyleBackColor = true;
            this.removeEquipmentFromCreatureButton.Click += new System.EventHandler(this.removeEquipmentFromCreatureButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Creatures (possibly equipped):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Equipment in Play:";
            // 
            // equipmentCB
            // 
            this.equipmentCB.FormattingEnabled = true;
            this.equipmentCB.Location = new System.Drawing.Point(12, 104);
            this.equipmentCB.Name = "equipmentCB";
            this.equipmentCB.Size = new System.Drawing.Size(337, 21);
            this.equipmentCB.TabIndex = 4;
            // 
            // removeEquipmentButton
            // 
            this.removeEquipmentButton.Location = new System.Drawing.Point(396, 101);
            this.removeEquipmentButton.Name = "removeEquipmentButton";
            this.removeEquipmentButton.Size = new System.Drawing.Size(75, 23);
            this.removeEquipmentButton.TabIndex = 5;
            this.removeEquipmentButton.Text = "Remove";
            this.removeEquipmentButton.UseVisualStyleBackColor = true;
            this.removeEquipmentButton.Click += new System.EventHandler(this.removeEquipmentButton_Click);
            // 
            // removeEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 156);
            this.Controls.Add(this.removeEquipmentButton);
            this.Controls.Add(this.equipmentCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeEquipmentFromCreatureButton);
            this.Controls.Add(this.CreatureCB);
            this.Name = "removeEquipmentForm";
            this.Text = "Remove Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CreatureCB;
        private System.Windows.Forms.Button removeEquipmentFromCreatureButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox equipmentCB;
        private System.Windows.Forms.Button removeEquipmentButton;
    }
}