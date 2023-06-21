namespace Library
{
    partial class Library
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_library = new System.Windows.Forms.DataGridView();
            this.button_book = new System.Windows.Forms.Button();
            this.button_customer = new System.Windows.Forms.Button();
            this.comboBox_customer_date_of_birth = new System.Windows.Forms.ComboBox();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.comboBox_author = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_author_title = new System.Windows.Forms.ComboBox();
            this.button_new_borrow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_library)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_library
            // 
            this.dataGridView_library.AllowUserToAddRows = false;
            this.dataGridView_library.AllowUserToDeleteRows = false;
            this.dataGridView_library.AllowUserToResizeColumns = false;
            this.dataGridView_library.AllowUserToResizeRows = false;
            this.dataGridView_library.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_library.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_library.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_library.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_library.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_library.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_library.Location = new System.Drawing.Point(11, 218);
            this.dataGridView_library.MultiSelect = false;
            this.dataGridView_library.Name = "dataGridView_library";
            this.dataGridView_library.ReadOnly = true;
            this.dataGridView_library.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_library.Size = new System.Drawing.Size(711, 231);
            this.dataGridView_library.TabIndex = 0;
            this.dataGridView_library.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_library_KeyPress);
            // 
            // button_book
            // 
            this.button_book.Location = new System.Drawing.Point(110, 63);
            this.button_book.Name = "button_book";
            this.button_book.Size = new System.Drawing.Size(91, 29);
            this.button_book.TabIndex = 1;
            this.button_book.Text = "Books";
            this.button_book.UseVisualStyleBackColor = true;
            this.button_book.Click += new System.EventHandler(this.button_book_Click);
            // 
            // button_customer
            // 
            this.button_customer.Location = new System.Drawing.Point(7, 63);
            this.button_customer.Name = "button_customer";
            this.button_customer.Size = new System.Drawing.Size(91, 29);
            this.button_customer.TabIndex = 3;
            this.button_customer.Text = "Customers";
            this.button_customer.UseVisualStyleBackColor = true;
            this.button_customer.Click += new System.EventHandler(this.button_customer_Click);
            // 
            // comboBox_customer_date_of_birth
            // 
            this.comboBox_customer_date_of_birth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_customer_date_of_birth.Enabled = false;
            this.comboBox_customer_date_of_birth.FormattingEnabled = true;
            this.comboBox_customer_date_of_birth.Location = new System.Drawing.Point(298, 119);
            this.comboBox_customer_date_of_birth.Name = "comboBox_customer_date_of_birth";
            this.comboBox_customer_date_of_birth.Size = new System.Drawing.Size(98, 21);
            this.comboBox_customer_date_of_birth.TabIndex = 57;
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(110, 119);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(98, 21);
            this.comboBox_customer.TabIndex = 56;
            this.comboBox_customer.DropDownClosed += new System.EventHandler(this.comboBox_customer_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 26);
            this.label3.TabIndex = 55;
            this.label3.Text = "Customer\r\nDate of birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 54;
            this.label5.Text = "Customer Name\r\nCustomer Last Name";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(478, 167);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(98, 20);
            this.textBox_count.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Count";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(7, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 58;
            this.BackButton.Text = "<<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(110, 12);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 28);
            this.button_reset.TabIndex = 59;
            this.button_reset.Text = "REFRESH";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // comboBox_author
            // 
            this.comboBox_author.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_author.FormattingEnabled = true;
            this.comboBox_author.Location = new System.Drawing.Point(110, 166);
            this.comboBox_author.Name = "comboBox_author";
            this.comboBox_author.Size = new System.Drawing.Size(98, 21);
            this.comboBox_author.TabIndex = 64;
            this.comboBox_author.DropDownClosed += new System.EventHandler(this.comboBox_author_DropDownClosed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 62;
            this.label4.Text = "Author Name\r\nAuthor Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Title";
            // 
            // comboBox_author_title
            // 
            this.comboBox_author_title.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_author_title.Enabled = false;
            this.comboBox_author_title.FormattingEnabled = true;
            this.comboBox_author_title.Location = new System.Drawing.Point(298, 167);
            this.comboBox_author_title.Name = "comboBox_author_title";
            this.comboBox_author_title.Size = new System.Drawing.Size(98, 21);
            this.comboBox_author_title.TabIndex = 66;
            // 
            // button_new_borrow
            // 
            this.button_new_borrow.Location = new System.Drawing.Point(608, 162);
            this.button_new_borrow.Name = "button_new_borrow";
            this.button_new_borrow.Size = new System.Drawing.Size(91, 29);
            this.button_new_borrow.TabIndex = 67;
            this.button_new_borrow.Text = "New borrow";
            this.button_new_borrow.UseVisualStyleBackColor = true;
            this.button_new_borrow.Click += new System.EventHandler(this.button_new_borrow_Click);
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.button_new_borrow);
            this.Controls.Add(this.comboBox_author_title);
            this.Controls.Add(this.comboBox_author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.comboBox_customer_date_of_birth);
            this.Controls.Add(this.comboBox_customer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_library);
            this.Controls.Add(this.button_book);
            this.Controls.Add(this.button_customer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Library";
            this.Text = "Library";
            this.Load += new System.EventHandler(this.Library_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_library)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_library;
        private System.Windows.Forms.Button button_book;
        private System.Windows.Forms.Button button_customer;
        private System.Windows.Forms.ComboBox comboBox_customer_date_of_birth;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.ComboBox comboBox_author;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_author_title;
        private System.Windows.Forms.Button button_new_borrow;
    }
}

