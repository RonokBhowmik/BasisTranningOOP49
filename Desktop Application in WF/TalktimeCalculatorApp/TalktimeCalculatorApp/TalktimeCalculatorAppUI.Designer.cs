namespace TalktimeCalculatorApp
{
    partial class TalktimeCalculatorAppUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculateTalktimeButton = new System.Windows.Forms.Button();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.paymentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.operatorNameComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operator Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calculated Talktime";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // calculateTalktimeButton
            // 
            this.calculateTalktimeButton.Location = new System.Drawing.Point(99, 137);
            this.calculateTalktimeButton.Name = "calculateTalktimeButton";
            this.calculateTalktimeButton.Size = new System.Drawing.Size(120, 23);
            this.calculateTalktimeButton.TabIndex = 5;
            this.calculateTalktimeButton.Text = "Calculate Talk Time";
            this.calculateTalktimeButton.UseVisualStyleBackColor = true;
            this.calculateTalktimeButton.Click += new System.EventHandler(this.calculateTalktimeButton_Click);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(99, 20);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(130, 20);
            this.balanceTextBox.TabIndex = 6;
            // 
            // paymentTypeComboBox
            // 
            this.paymentTypeComboBox.FormattingEnabled = true;
            this.paymentTypeComboBox.Items.AddRange(new object[] {
            "Postpaid",
            "Prepaid"});
            this.paymentTypeComboBox.Location = new System.Drawing.Point(99, 59);
            this.paymentTypeComboBox.Name = "paymentTypeComboBox";
            this.paymentTypeComboBox.Size = new System.Drawing.Size(130, 21);
            this.paymentTypeComboBox.TabIndex = 7;
            // 
            // operatorNameComboBox
            // 
            this.operatorNameComboBox.FormattingEnabled = true;
            this.operatorNameComboBox.Items.AddRange(new object[] {
            "GrammenPhone",
            "Banglalink",
            "Robi",
            "Airtel"});
            this.operatorNameComboBox.Location = new System.Drawing.Point(99, 95);
            this.operatorNameComboBox.Name = "operatorNameComboBox";
            this.operatorNameComboBox.Size = new System.Drawing.Size(130, 21);
            this.operatorNameComboBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "miniutes";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(216, 211);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // TalktimeCalculatorAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 246);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.operatorNameComboBox);
            this.Controls.Add(this.paymentTypeComboBox);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.calculateTalktimeButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TalktimeCalculatorAppUI";
            this.Text = "Talktime Calculator Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculateTalktimeButton;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.ComboBox paymentTypeComboBox;
        private System.Windows.Forms.ComboBox operatorNameComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button resetButton;
    }
}

