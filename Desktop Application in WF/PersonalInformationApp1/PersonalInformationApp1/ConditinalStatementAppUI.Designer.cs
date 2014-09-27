namespace PersonalInformationApp1
{
    partial class ConditinalStatementAppUI
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
            this.planetNumberButton = new System.Windows.Forms.Button();
            this.planetNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // planetNumberButton
            // 
            this.planetNumberButton.Location = new System.Drawing.Point(129, 68);
            this.planetNumberButton.Name = "planetNumberButton";
            this.planetNumberButton.Size = new System.Drawing.Size(140, 23);
            this.planetNumberButton.TabIndex = 0;
            this.planetNumberButton.Text = "Show Planet Number";
            this.planetNumberButton.UseVisualStyleBackColor = true;
            this.planetNumberButton.Click += new System.EventHandler(this.planetNumberButton_Click);
            // 
            // planetNameComboBox
            // 
            this.planetNameComboBox.FormattingEnabled = true;
            this.planetNameComboBox.Items.AddRange(new object[] {
            "Planet",
            "Saturn ",
            "Mars",
            "Jupitar",
            "Earth"});
            this.planetNameComboBox.Location = new System.Drawing.Point(129, 25);
            this.planetNameComboBox.Name = "planetNameComboBox";
            this.planetNameComboBox.Size = new System.Drawing.Size(140, 21);
            this.planetNameComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Planet Name";
            // 
            // ConditinalStatementAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.planetNameComboBox);
            this.Controls.Add(this.planetNumberButton);
            this.Name = "ConditinalStatementAppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conditional Statement Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button planetNumberButton;
        private System.Windows.Forms.ComboBox planetNameComboBox;
        private System.Windows.Forms.Label label1;
    }
}

