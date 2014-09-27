namespace CustomerQueueManagementApp
{
    partial class CustomerQueueManagementAppUI
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
            this.enqueueCustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.enqueueCustomerComplainTextBox = new System.Windows.Forms.TextBox();
            this.enqueueCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dequeueGroupBox = new System.Windows.Forms.GroupBox();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.dequeueComplainTextBox = new System.Windows.Forms.TextBox();
            this.dequeueCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerSerialNoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.waitingQueueGroupBox = new System.Windows.Forms.GroupBox();
            this.myListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enqueueCustomerGroupBox.SuspendLayout();
            this.dequeueGroupBox.SuspendLayout();
            this.waitingQueueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enqueueCustomerGroupBox
            // 
            this.enqueueCustomerGroupBox.Controls.Add(this.enqueueButton);
            this.enqueueCustomerGroupBox.Controls.Add(this.enqueueCustomerComplainTextBox);
            this.enqueueCustomerGroupBox.Controls.Add(this.enqueueCustomerNameTextBox);
            this.enqueueCustomerGroupBox.Controls.Add(this.label2);
            this.enqueueCustomerGroupBox.Controls.Add(this.label1);
            this.enqueueCustomerGroupBox.Location = new System.Drawing.Point(12, 12);
            this.enqueueCustomerGroupBox.Name = "enqueueCustomerGroupBox";
            this.enqueueCustomerGroupBox.Size = new System.Drawing.Size(402, 146);
            this.enqueueCustomerGroupBox.TabIndex = 0;
            this.enqueueCustomerGroupBox.TabStop = false;
            this.enqueueCustomerGroupBox.Text = "Enqueue Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(75, 101);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(117, 23);
            this.enqueueButton.TabIndex = 4;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // enqueueCustomerComplainTextBox
            // 
            this.enqueueCustomerComplainTextBox.Location = new System.Drawing.Point(75, 62);
            this.enqueueCustomerComplainTextBox.Name = "enqueueCustomerComplainTextBox";
            this.enqueueCustomerComplainTextBox.Size = new System.Drawing.Size(220, 20);
            this.enqueueCustomerComplainTextBox.TabIndex = 3;
            // 
            // enqueueCustomerNameTextBox
            // 
            this.enqueueCustomerNameTextBox.Location = new System.Drawing.Point(75, 26);
            this.enqueueCustomerNameTextBox.Name = "enqueueCustomerNameTextBox";
            this.enqueueCustomerNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.enqueueCustomerNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complain";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dequeueGroupBox
            // 
            this.dequeueGroupBox.Controls.Add(this.dequeueButton);
            this.dequeueGroupBox.Controls.Add(this.dequeueComplainTextBox);
            this.dequeueGroupBox.Controls.Add(this.dequeueCustomerNameTextBox);
            this.dequeueGroupBox.Controls.Add(this.customerSerialNoTextBox);
            this.dequeueGroupBox.Controls.Add(this.label5);
            this.dequeueGroupBox.Controls.Add(this.label4);
            this.dequeueGroupBox.Controls.Add(this.label3);
            this.dequeueGroupBox.Location = new System.Drawing.Point(420, 12);
            this.dequeueGroupBox.Name = "dequeueGroupBox";
            this.dequeueGroupBox.Size = new System.Drawing.Size(406, 146);
            this.dequeueGroupBox.TabIndex = 1;
            this.dequeueGroupBox.TabStop = false;
            this.dequeueGroupBox.Text = "Dequeue Customer";
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(261, 21);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(115, 23);
            this.dequeueButton.TabIndex = 6;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // dequeueComplainTextBox
            // 
            this.dequeueComplainTextBox.Location = new System.Drawing.Point(79, 98);
            this.dequeueComplainTextBox.Name = "dequeueComplainTextBox";
            this.dequeueComplainTextBox.Size = new System.Drawing.Size(189, 20);
            this.dequeueComplainTextBox.TabIndex = 5;
            // 
            // dequeueCustomerNameTextBox
            // 
            this.dequeueCustomerNameTextBox.Location = new System.Drawing.Point(79, 59);
            this.dequeueCustomerNameTextBox.Name = "dequeueCustomerNameTextBox";
            this.dequeueCustomerNameTextBox.Size = new System.Drawing.Size(139, 20);
            this.dequeueCustomerNameTextBox.TabIndex = 4;
            // 
            // customerSerialNoTextBox
            // 
            this.customerSerialNoTextBox.Location = new System.Drawing.Point(79, 23);
            this.customerSerialNoTextBox.Name = "customerSerialNoTextBox";
            this.customerSerialNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerSerialNoTextBox.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Complain";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Serial No";
            // 
            // waitingQueueGroupBox
            // 
            this.waitingQueueGroupBox.Controls.Add(this.myListView);
            this.waitingQueueGroupBox.Location = new System.Drawing.Point(12, 174);
            this.waitingQueueGroupBox.Name = "waitingQueueGroupBox";
            this.waitingQueueGroupBox.Size = new System.Drawing.Size(814, 259);
            this.waitingQueueGroupBox.TabIndex = 2;
            this.waitingQueueGroupBox.TabStop = false;
            this.waitingQueueGroupBox.Text = "Waiting Queue";
            // 
            // myListView
            // 
            this.myListView.BackColor = System.Drawing.SystemColors.Window;
            this.myListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.myListView.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.myListView.Location = new System.Drawing.Point(36, 35);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(748, 190);
            this.myListView.TabIndex = 0;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Serial No";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Complain";
            // 
            // CustomerQueueManagementAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 463);
            this.Controls.Add(this.waitingQueueGroupBox);
            this.Controls.Add(this.dequeueGroupBox);
            this.Controls.Add(this.enqueueCustomerGroupBox);
            this.Name = "CustomerQueueManagementAppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Queue Management Application";
            this.enqueueCustomerGroupBox.ResumeLayout(false);
            this.enqueueCustomerGroupBox.PerformLayout();
            this.dequeueGroupBox.ResumeLayout(false);
            this.dequeueGroupBox.PerformLayout();
            this.waitingQueueGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox enqueueCustomerGroupBox;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.TextBox enqueueCustomerComplainTextBox;
        private System.Windows.Forms.TextBox enqueueCustomerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox dequeueGroupBox;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.TextBox dequeueComplainTextBox;
        private System.Windows.Forms.TextBox dequeueCustomerNameTextBox;
        private System.Windows.Forms.TextBox customerSerialNoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox waitingQueueGroupBox;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

