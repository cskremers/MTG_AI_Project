namespace MTG_AI
{
    partial class addToHandForm
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
            this.dragonsRB = new System.Windows.Forms.RadioButton();
            this.knightsRB = new System.Windows.Forms.RadioButton();
            this.addToHandCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(314, 46);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Card to Add (case specific):";
            // 
            // dragonsRB
            // 
            this.dragonsRB.AutoSize = true;
            this.dragonsRB.Location = new System.Drawing.Point(78, 12);
            this.dragonsRB.Name = "dragonsRB";
            this.dragonsRB.Size = new System.Drawing.Size(65, 17);
            this.dragonsRB.TabIndex = 7;
            this.dragonsRB.Text = "Dragons";
            this.dragonsRB.UseVisualStyleBackColor = true;
            this.dragonsRB.CheckedChanged += new System.EventHandler(this.dragonsRB_CheckedChanged);
            // 
            // knightsRB
            // 
            this.knightsRB.AutoSize = true;
            this.knightsRB.Checked = true;
            this.knightsRB.Location = new System.Drawing.Point(12, 12);
            this.knightsRB.Name = "knightsRB";
            this.knightsRB.Size = new System.Drawing.Size(60, 17);
            this.knightsRB.TabIndex = 6;
            this.knightsRB.TabStop = true;
            this.knightsRB.Text = "Knights";
            this.knightsRB.UseVisualStyleBackColor = true;
            this.knightsRB.CheckedChanged += new System.EventHandler(this.knightsRB_CheckedChanged);
            // 
            // addToHandCB
            // 
            this.addToHandCB.FormattingEnabled = true;
            this.addToHandCB.Location = new System.Drawing.Point(12, 48);
            this.addToHandCB.Name = "addToHandCB";
            this.addToHandCB.Size = new System.Drawing.Size(284, 21);
            this.addToHandCB.TabIndex = 8;
            // 
            // addToHandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 95);
            this.Controls.Add(this.addToHandCB);
            this.Controls.Add(this.dragonsRB);
            this.Controls.Add(this.knightsRB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Name = "addToHandForm";
            this.Text = "Add to my hand";
            this.Load += new System.EventHandler(this.addToHandForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dragonsRB;
        private System.Windows.Forms.RadioButton knightsRB;
        private System.Windows.Forms.ComboBox addToHandCB;
    }
}