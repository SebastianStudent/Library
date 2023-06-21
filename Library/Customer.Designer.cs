namespace Library
{
    partial class Customer
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.monthCalendar_date_of_birth = new System.Windows.Forms.MonthCalendar();
            this.button_new_customer = new System.Windows.Forms.Button();
            this.dataGridView_customer = new System.Windows.Forms.DataGridView();
            this.checkedListBox_search_mode = new System.Windows.Forms.CheckedListBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(2, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Date of birth";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(43, 85);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(87, 20);
            this.textBox_name.TabIndex = 15;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(215, 85);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(87, 20);
            this.textBox_last_name.TabIndex = 16;
            // 
            // monthCalendar_date_of_birth
            // 
            this.monthCalendar_date_of_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthCalendar_date_of_birth.Location = new System.Drawing.Point(408, 18);
            this.monthCalendar_date_of_birth.MaxSelectionCount = 1;
            this.monthCalendar_date_of_birth.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.monthCalendar_date_of_birth.Name = "monthCalendar_date_of_birth";
            this.monthCalendar_date_of_birth.ShowTodayCircle = false;
            this.monthCalendar_date_of_birth.TabIndex = 18;
            // 
            // button_new_customer
            // 
            this.button_new_customer.Location = new System.Drawing.Point(689, 80);
            this.button_new_customer.Name = "button_new_customer";
            this.button_new_customer.Size = new System.Drawing.Size(70, 36);
            this.button_new_customer.TabIndex = 19;
            this.button_new_customer.Text = "New customer";
            this.button_new_customer.UseVisualStyleBackColor = true;
            this.button_new_customer.Click += new System.EventHandler(this.button_new_customer_Click);
            // 
            // dataGridView_customer
            // 
            this.dataGridView_customer.AllowUserToAddRows = false;
            this.dataGridView_customer.AllowUserToDeleteRows = false;
            this.dataGridView_customer.AllowUserToResizeColumns = false;
            this.dataGridView_customer.AllowUserToResizeRows = false;
            this.dataGridView_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_customer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_customer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_customer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_customer.Location = new System.Drawing.Point(12, 192);
            this.dataGridView_customer.MultiSelect = false;
            this.dataGridView_customer.Name = "dataGridView_customer";
            this.dataGridView_customer.ReadOnly = true;
            this.dataGridView_customer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_customer.Size = new System.Drawing.Size(746, 224);
            this.dataGridView_customer.TabIndex = 20;
            this.dataGridView_customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_customer_KeyPress);
            // 
            // checkedListBox_search_mode
            // 
            this.checkedListBox_search_mode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBox_search_mode.FormattingEnabled = true;
            this.checkedListBox_search_mode.Items.AddRange(new object[] {
            "At the beginning",
            "In the middle",
            "At the end"});
            this.checkedListBox_search_mode.Location = new System.Drawing.Point(215, 131);
            this.checkedListBox_search_mode.Name = "checkedListBox_search_mode";
            this.checkedListBox_search_mode.Size = new System.Drawing.Size(104, 49);
            this.checkedListBox_search_mode.TabIndex = 21;
            this.checkedListBox_search_mode.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_search_mode_SelectedIndexChanged);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(325, 146);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(68, 20);
            this.button_search.TabIndex = 22;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(58, 146);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(151, 20);
            this.textBox_search.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 24;
            this.label4.Text = "Search\r\ncustomer";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(115, 12);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 28);
            this.button_reset.TabIndex = 25;
            this.button_reset.Text = "REFRESH";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.checkedListBox_search_mode);
            this.Controls.Add(this.dataGridView_customer);
            this.Controls.Add(this.button_new_customer);
            this.Controls.Add(this.monthCalendar_date_of_birth);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 490);
            this.MinimumSize = new System.Drawing.Size(815, 490);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.Button button_new_customer;
        private System.Windows.Forms.MonthCalendar monthCalendar_date_of_birth;
        private System.Windows.Forms.DataGridView dataGridView_customer;
        private System.Windows.Forms.CheckedListBox checkedListBox_search_mode;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_reset;
    }
}