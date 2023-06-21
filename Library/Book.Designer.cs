namespace Library
{
    partial class Book
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
            this.button_reset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.checkedListBox_search_mode = new System.Windows.Forms.CheckedListBox();
            this.dataGridView_books = new System.Windows.Forms.DataGridView();
            this.button_new_book = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_name = new System.Windows.Forms.ComboBox();
            this.comboBox_last_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).BeginInit();
            this.SuspendLayout();
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(115, 12);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(75, 28);
            this.button_reset.TabIndex = 39;
            this.button_reset.Text = "REFRESH";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 39);
            this.label4.TabIndex = 38;
            this.label4.Text = "Search\r\nauthors\r\nor books";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(58, 146);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(287, 20);
            this.textBox_search.TabIndex = 37;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(461, 146);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(68, 20);
            this.button_search.TabIndex = 36;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // checkedListBox_search_mode
            // 
            this.checkedListBox_search_mode.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkedListBox_search_mode.FormattingEnabled = true;
            this.checkedListBox_search_mode.Items.AddRange(new object[] {
            "At the beginning",
            "In the middle",
            "At the end"});
            this.checkedListBox_search_mode.Location = new System.Drawing.Point(351, 130);
            this.checkedListBox_search_mode.Name = "checkedListBox_search_mode";
            this.checkedListBox_search_mode.Size = new System.Drawing.Size(104, 49);
            this.checkedListBox_search_mode.TabIndex = 35;
            this.checkedListBox_search_mode.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_search_mode_SelectedIndexChanged);
            // 
            // dataGridView_books
            // 
            this.dataGridView_books.AllowUserToAddRows = false;
            this.dataGridView_books.AllowUserToDeleteRows = false;
            this.dataGridView_books.AllowUserToResizeColumns = false;
            this.dataGridView_books.AllowUserToResizeRows = false;
            this.dataGridView_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_books.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_books.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_books.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_books.Location = new System.Drawing.Point(12, 192);
            this.dataGridView_books.MultiSelect = false;
            this.dataGridView_books.Name = "dataGridView_books";
            this.dataGridView_books.ReadOnly = true;
            this.dataGridView_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_books.Size = new System.Drawing.Size(746, 224);
            this.dataGridView_books.TabIndex = 34;
            this.dataGridView_books.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_customer_KeyPress);
            // 
            // button_new_book
            // 
            this.button_new_book.Location = new System.Drawing.Point(670, 60);
            this.button_new_book.Name = "button_new_book";
            this.button_new_book.Size = new System.Drawing.Size(70, 36);
            this.button_new_book.TabIndex = 33;
            this.button_new_book.Text = "New Book";
            this.button_new_book.UseVisualStyleBackColor = true;
            this.button_new_book.Click += new System.EventHandler(this.button_new_book_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 29);
            this.BackButton.TabIndex = 26;
            this.BackButton.Text = "<<";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(558, 69);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(87, 20);
            this.textBox_count.TabIndex = 43;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(386, 69);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(87, 20);
            this.textBox_title.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Count";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Last name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Name";
            // 
            // comboBox_name
            // 
            this.comboBox_name.FormattingEnabled = true;
            this.comboBox_name.Location = new System.Drawing.Point(55, 68);
            this.comboBox_name.Name = "comboBox_name";
            this.comboBox_name.Size = new System.Drawing.Size(98, 21);
            this.comboBox_name.TabIndex = 48;
            this.comboBox_name.DropDown += new System.EventHandler(this.comboBox_name_DropDown);
            // 
            // comboBox_last_name
            // 
            this.comboBox_last_name.FormattingEnabled = true;
            this.comboBox_last_name.Location = new System.Drawing.Point(227, 68);
            this.comboBox_last_name.Name = "comboBox_last_name";
            this.comboBox_last_name.Size = new System.Drawing.Size(98, 21);
            this.comboBox_last_name.TabIndex = 49;
            this.comboBox_last_name.DropDown += new System.EventHandler(this.comboBox_last_name_DropDown);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.comboBox_last_name);
            this.Controls.Add(this.comboBox_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.checkedListBox_search_mode);
            this.Controls.Add(this.dataGridView_books);
            this.Controls.Add(this.button_new_book);
            this.Controls.Add(this.BackButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 490);
            this.MinimumSize = new System.Drawing.Size(815, 490);
            this.Name = "Book";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_books)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.CheckedListBox checkedListBox_search_mode;
        private System.Windows.Forms.DataGridView dataGridView_books;
        private System.Windows.Forms.Button button_new_book;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_name;
        private System.Windows.Forms.ComboBox comboBox_last_name;
    }
}