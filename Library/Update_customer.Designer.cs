namespace Library
{
    partial class Update_customer
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
            this.button_update_customer = new System.Windows.Forms.Button();
            this.monthCalendar_date_of_birth = new System.Windows.Forms.MonthCalendar();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_update_customer
            // 
            this.button_update_customer.Location = new System.Drawing.Point(196, 339);
            this.button_update_customer.Name = "button_update_customer";
            this.button_update_customer.Size = new System.Drawing.Size(70, 36);
            this.button_update_customer.TabIndex = 27;
            this.button_update_customer.Text = "Update customer";
            this.button_update_customer.UseVisualStyleBackColor = true;
            this.button_update_customer.Click += new System.EventHandler(this.button_update_customer_Click);
            // 
            // monthCalendar_date_of_birth
            // 
            this.monthCalendar_date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar_date_of_birth.Location = new System.Drawing.Point(97, 155);
            this.monthCalendar_date_of_birth.MaxSelectionCount = 1;
            this.monthCalendar_date_of_birth.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.monthCalendar_date_of_birth.Name = "monthCalendar_date_of_birth";
            this.monthCalendar_date_of_birth.ShowTodayCircle = false;
            this.monthCalendar_date_of_birth.TabIndex = 26;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(179, 110);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(87, 20);
            this.textBox_last_name.TabIndex = 25;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(179, 62);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(87, 20);
            this.textBox_name.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Date of birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 20;
            this.BackButton.Text = "<<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Update_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 451);
            this.Controls.Add(this.button_update_customer);
            this.Controls.Add(this.monthCalendar_date_of_birth);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 490);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 490);
            this.Name = "Update_customer";
            this.Text = "Update Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_update_customer;
        private System.Windows.Forms.MonthCalendar monthCalendar_date_of_birth;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
    }
}