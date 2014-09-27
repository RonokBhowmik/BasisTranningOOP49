namespace EmployeeSalaryApp
{
    partial class EmployeeSalaryBonusCalculatorAppUI
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
            this.calculateBonusButton = new System.Windows.Forms.Button();
            this.employeeSalaryTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.grossSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Salary";
            // 
            // calculateBonusButton
            // 
            this.calculateBonusButton.Location = new System.Drawing.Point(115, 87);
            this.calculateBonusButton.Name = "calculateBonusButton";
            this.calculateBonusButton.Size = new System.Drawing.Size(109, 23);
            this.calculateBonusButton.TabIndex = 1;
            this.calculateBonusButton.Text = "Calculate Bonus";
            this.calculateBonusButton.UseVisualStyleBackColor = true;
            this.calculateBonusButton.Click += new System.EventHandler(this.calculateBonusButton_Click);
            // 
            // employeeSalaryTextBox
            // 
            this.employeeSalaryTextBox.Location = new System.Drawing.Point(115, 34);
            this.employeeSalaryTextBox.Name = "employeeSalaryTextBox";
            this.employeeSalaryTextBox.Size = new System.Drawing.Size(134, 20);
            this.employeeSalaryTextBox.TabIndex = 2;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(115, 138);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(58, 20);
            this.bonusTextBox.TabIndex = 3;
            // 
            // grossSalaryTextBox
            // 
            this.grossSalaryTextBox.Location = new System.Drawing.Point(115, 181);
            this.grossSalaryTextBox.Name = "grossSalaryTextBox";
            this.grossSalaryTextBox.Size = new System.Drawing.Size(134, 20);
            this.grossSalaryTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bonus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Gross Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "%";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(174, 227);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // EmployeeSalaryBonusCalculatorAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 275);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grossSalaryTextBox);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.employeeSalaryTextBox);
            this.Controls.Add(this.calculateBonusButton);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeSalaryBonusCalculatorAppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Salary Bonus Calculator App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateBonusButton;
        private System.Windows.Forms.TextBox employeeSalaryTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.TextBox grossSalaryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resetButton;
    }
}

