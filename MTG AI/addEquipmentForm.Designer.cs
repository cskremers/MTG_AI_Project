namespace MTG_AI
{
    partial class addEquipmentForm
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
            this.equipmentCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreatureCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addEquipmentButton = new System.Windows.Forms.Button();
            this.equipCreatureCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentCB
            // 
            this.equipmentCB.FormattingEnabled = true;
            this.equipmentCB.Location = new System.Drawing.Point(38, 55);
            this.equipmentCB.Name = "equipmentCB";
            this.equipmentCB.Size = new System.Drawing.Size(229, 21);
            this.equipmentCB.TabIndex = 0;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipment to Add";
            // 
            // CreatureCB
            // 
            this.CreatureCB.FormattingEnabled = true;
            this.CreatureCB.Location = new System.Drawing.Point(38, 183);
            this.CreatureCB.Name = "CreatureCB";
            this.CreatureCB.Size = new System.Drawing.Size(229, 21);
            this.CreatureCB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Creature to Equip";
            // 
            // addEquipmentButton
            // 
            this.addEquipmentButton.Location = new System.Drawing.Point(38, 242);
            this.addEquipmentButton.Name = "addEquipmentButton";
            this.addEquipmentButton.Size = new System.Drawing.Size(229, 23);
            this.addEquipmentButton.TabIndex = 4;
            this.addEquipmentButton.Text = "Add Equipment";
            this.addEquipmentButton.UseVisualStyleBackColor = true;
            this.addEquipmentButton.Click += new System.EventHandler(this.addEquipmentButton_Click);
            // 
            // equipCreatureCheckBox
            // 
            this.equipCreatureCheckBox.AutoSize = true;
            this.equipCreatureCheckBox.Location = new System.Drawing.Point(18, 19);
            this.equipCreatureCheckBox.Name = "equipCreatureCheckBox";
            this.equipCreatureCheckBox.Size = new System.Drawing.Size(102, 17);
            this.equipCreatureCheckBox.TabIndex = 5;
            this.equipCreatureCheckBox.Text = "Equip Creature?";
            this.equipCreatureCheckBox.UseVisualStyleBackColor = true;
            this.equipCreatureCheckBox.CheckedChanged += new System.EventHandler(this.equipCreatureCheckBox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.equipCreatureCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(23, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 120);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // addEquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 276);
            this.Controls.Add(this.addEquipmentButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreatureCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.equipmentCB);
            this.Controls.Add(this.groupBox1);
            this.Name = "addEquipmentForm";
            this.Text = "Add Equipment";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox equipmentCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CreatureCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addEquipmentButton;
        private System.Windows.Forms.CheckBox equipCreatureCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}