namespace MTG_AI
{
    partial class removeFromHandForm
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
            this.removeFromHandCB = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // removeFromHandCB
            // 
            this.removeFromHandCB.FormattingEnabled = true;
            this.removeFromHandCB.Location = new System.Drawing.Point(23, 44);
            this.removeFromHandCB.Name = "removeFromHandCB";
            this.removeFromHandCB.Size = new System.Drawing.Size(317, 21);
            this.removeFromHandCB.TabIndex = 0;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(372, 41);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeFromHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 116);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.removeFromHandCB);
            this.Name = "removeFromHand";
            this.Text = "removeFromHand";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox removeFromHandCB;
        private System.Windows.Forms.Button removeButton;

    }
}