namespace Library
{
    partial class Library_deliveryDate
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
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar_delivery_date = new System.Windows.Forms.MonthCalendar();
            this.button_delivery_date = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "<<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Delivery date";
            // 
            // monthCalendar_delivery_date
            // 
            this.monthCalendar_delivery_date.Location = new System.Drawing.Point(18, 64);
            this.monthCalendar_delivery_date.MaxSelectionCount = 1;
            this.monthCalendar_delivery_date.Name = "monthCalendar_delivery_date";
            this.monthCalendar_delivery_date.TabIndex = 69;
            // 
            // button_delivery_date
            // 
            this.button_delivery_date.Location = new System.Drawing.Point(120, 238);
            this.button_delivery_date.Name = "button_delivery_date";
            this.button_delivery_date.Size = new System.Drawing.Size(67, 55);
            this.button_delivery_date.TabIndex = 70;
            this.button_delivery_date.Text = "New delivery date";
            this.button_delivery_date.UseVisualStyleBackColor = true;
            this.button_delivery_date.Click += new System.EventHandler(this.button_delivery_date_Click);
            // 
            // Library_deliveryDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 321);
            this.Controls.Add(this.button_delivery_date);
            this.Controls.Add(this.monthCalendar_delivery_date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 360);
            this.MinimumSize = new System.Drawing.Size(340, 360);
            this.Name = "Library_deliveryDate";
            this.Text = "Library delivery date";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar_delivery_date;
        private System.Windows.Forms.Button button_delivery_date;
    }
}