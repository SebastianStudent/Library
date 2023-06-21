using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Book : Form
    {
        CheckCorrect checkCorrectClass = new CheckCorrect();
        private static int row_count;
        public static int ColumnCount;
        public static string Update_Name = "";
        public static string Update_Last_name = "";
        public static string Update_Title = "";
        public static string Update_Count = "";
        public Book()
        {
            InitializeComponent();
        }
        private void Book_Load(object sender, EventArgs e)
        {
            enable_search();
            try
            {
                Library.sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Library.sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return;
            }
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM books ORDER BY Id_Book", Library.sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
            }
            else
            {
                reader.Close();
                Library.sqlConnection.Close();
                MessageBox.Show("Please contact with us to solve this problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777",
                    "Database is empty");
                return;
            }
            try
            {
                DataTable dataTable = new DataTable();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                dataGridView_books.DataSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                Library.sqlConnection.Close();
                MessageBox.Show("Click button REFRESH application or contact with us to solve your problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777\n\n" + ex,
                    "ERROR with data!");
                return;
            }
            sqlCommand = new MySqlCommand("SELECT COUNT(Id_Book) FROM Books", Library.sqlConnection);
            reader = sqlCommand.ExecuteReader();
            row_count = 0;
            if (reader.Read())
            {
                row_count = Convert.ToInt16(reader.GetValue(0));
                reader.Close();
            }
            else
            {
                reader.Close();
                MessageBox.Show("Please contact with us to solve this problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777",
                    "Database is empty");
                Library.sqlConnection.Close();
                return;
            }
            Library.sqlConnection.Close();
            foreach (DataGridViewColumn column in dataGridView_books.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            Book_Load(null, null);
        }
        private void checkedListBox_search_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox_search_mode.Items.Count; i++)
            {
                if (checkedListBox_search_mode.SelectedIndex != i)
                {
                    checkedListBox_search_mode.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            if (!checkedListBox_search_mode.GetItemChecked(0) &&
               !checkedListBox_search_mode.GetItemChecked(1) &&
               !checkedListBox_search_mode.GetItemChecked(2))
            {
                MessageBox.Show("Please select search mode in box");
                return;
            }
            else if (checkCorrectClass.IsEmptyTextBox(textBox_search.Text.ToString()))
            {
                MessageBox.Show("You cannot search with empty date",
                    "Attention!");
                return;
            }
            ColumnCount = dataGridView_books.ColumnCount;
            if (checkedListBox_search_mode.GetItemChecked(0))
            {
                AtthebeginningSearch(ColumnCount,
                    dataGridView_books.RowCount,
                    textBox_search.Text.ToString());
            }
            else if (checkedListBox_search_mode.SelectedItem.ToString() == "In the middle")
            {
                InthemiddleSearch(ColumnCount,
                    dataGridView_books.RowCount,
                    textBox_search.Text.ToString());
            }
            else if (checkedListBox_search_mode.SelectedItem.ToString() == "At the end")
            {
                AttheendSearch(ColumnCount,
                    dataGridView_books.RowCount,
                    textBox_search.Text.ToString());
            }
            disable_search();
        }
        private void AtthebeginningSearch(int column_number, int row_number, string text)
        {
            string text_lower = text.ToLower();
            for (int i = row_number - 1; i >= 0; i--)
            {
                bool containt = true;
                for (int j = 0; j < column_number; j++)
                {
                    string cell_value = dataGridView_books.Rows[i].Cells[j].Value.ToString().ToLower();
                    if (cell_value.Length > text_lower.Length)
                    {
                        string cell_value_fragment = cell_value.Remove(text_lower.Length);
                        if (cell_value_fragment.Contains(text_lower))
                        {
                            containt = false;
                            break;
                        }
                    }
                    else if (cell_value.Length == text_lower.Length)
                    {
                        if (cell_value.Contains(text_lower))
                        {
                            containt = false;
                            break;
                        }
                    }
                }
                if (containt)
                {
                    dataGridView_books.Rows.RemoveAt(i);
                }
            }
        }
        private void InthemiddleSearch(int column_number, int row_number, string text)
        {
            string text_lower = text.ToLower();
            for (int i = row_number - 1; i >= 0; i--)
            {
                bool containt = true;
                for (int j = 0; j < column_number; j++)
                {
                    string cell_value = dataGridView_books.Rows[i].Cells[j].Value.ToString().ToLower();
                    if (cell_value.Length >= text_lower.Length)
                    {
                        if (cell_value.Contains(text_lower))
                        {
                            containt = false;
                            break;
                        }
                    }
                }
                if (containt)
                {
                    dataGridView_books.Rows.RemoveAt(i);
                }
            }
        }
        private void AttheendSearch(int column_number, int row_number, string text)
        {
            string text_lower = text.ToLower();
            for (int i = row_number - 1; i >= 0; i--)
            {
                bool containt = true;
                for (int j = 0; j < column_number; j++)
                {
                    string cell_value = dataGridView_books.Rows[i].Cells[j].Value.ToString().ToLower();
                    if (cell_value.Length > text_lower.Length)
                    {
                        string cell_value_fragment = cell_value.Substring(cell_value.Length - text_lower.Length);
                        if (cell_value_fragment.Contains(text_lower))
                        {
                            containt = false;
                            break;
                        }
                    }
                    else if (cell_value.Length == text_lower.Length)
                    {
                        if (cell_value.Contains(text_lower))
                        {
                            containt = false;
                            break;
                        }
                    }
                }
                if (containt)
                {
                    dataGridView_books.Rows.RemoveAt(i);
                }
            }
        }
        private void disable_search()
        {
            textBox_search.Enabled = false;
            checkedListBox_search_mode.Enabled = false;
            button_search.Enabled = false;
        }
        private void enable_search()
        {
            textBox_search.Enabled = true;
            checkedListBox_search_mode.Enabled = true;
            button_search.Enabled = true;
        }
        private void button_new_book_Click(object sender, EventArgs e)
        {
            try
            {
                Library.sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Library.sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return;
            }
            if (checkCorrectClass.IsEmptyComboBox(comboBox_name) ||
                checkCorrectClass.IsEmptyComboBox(comboBox_last_name) ||
                checkCorrectClass.IsEmptyTextBox(textBox_title.Text.ToString()) ||
                checkCorrectClass.IsEmptyTextBox(textBox_count.Text.ToString()))
            {
                MessageBox.Show("You cannot add empty date",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            if (checkCorrectClass.FalseName(comboBox_name.Text.ToString()))
            {
                MessageBox.Show("Incorrect name",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            if (checkCorrectClass.FalseLastName(comboBox_last_name.Text.ToString()))
            {
                MessageBox.Show("Incorrect last name",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            if (checkCorrectClass.FalsePlusNumber(textBox_count.Text.ToString()))
            {
                MessageBox.Show("Incorrect data in Count\nOr\nYou cannot add zero or less number",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            string CorrectName = checkCorrectClass.CorrectName(comboBox_name.Text.ToString());
            string CorrectLastName = checkCorrectClass.CorrectLastName(comboBox_last_name.Text.ToString());
            string Title = textBox_title.Text.ToString();
            string Count = checkCorrectClass.DeleteWhiteSpace(textBox_count.Text.ToString());
            DialogResult dialogResult = MessageBox.Show("Are you sure to CREATE that book?\n" +
                CorrectName + " " +
                CorrectLastName + " " +
                Title + " " +
                Count,
                "Add new book",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Library.sqlConnection.Close();
                Book_Load(null, null);
                try
                {
                    Library.sqlConnection.Open();
                }
                catch (Exception ex)
                {
                    Library.sqlConnection.Close();
                    MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                    return;
                }
                MySqlCommand sqlCommand = new MySqlCommand("SELECT COUNT(Id_Book) FROM Books", Library.sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                row_count = 0;
                int index = 0;
                if (reader.Read())
                {
                    row_count = Convert.ToInt16(reader.GetValue(0));
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Please contact with us to solve this problem\n" +
                        "helpdeskIT@contact.pl or 555-666-777",
                        "Database is empty");
                    Library.sqlConnection.Close();
                    return;
                }
                for (int i = 0; i < row_count; i++)
                {
                    if (Convert.ToInt16(dataGridView_books.Rows[i].Cells[0].Value) != (i + 1))
                    {
                        index = i + 1;
                        break;
                    }
                }
                if (index == 0)
                {
                    sqlCommand = new MySqlCommand("INSERT INTO `books` (`Id_Book`, `Name`, `Last name`, `Title`, `Count`) " +
                        "VALUES('" + (row_count + 1) + "', '" +
                        CorrectName + "', '" +
                        CorrectLastName + "', '" +
                        Title + "','" +
                        Count + "')",
                        Library.sqlConnection);
                }
                else
                {
                    sqlCommand = new MySqlCommand("INSERT INTO `books` (`Id_Book`, `Name`, `Last name`, `Title`, `Count`) " +
                        "VALUES('" + index + "', '" +
                        CorrectName + "', '" +
                        CorrectLastName + "', '" +
                        Title + "','" +
                        Count + "')",
                        Library.sqlConnection);
                }
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    comboBox_name.Text = "";
                    comboBox_last_name.Text = "";
                    textBox_title.Text = "";
                    textBox_count.Text = "";
                    Library.sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    Library.sqlConnection.Close();
                    MessageBox.Show("Network connection error or false data\n" + ex, "ERROR");
                    return;
                }
                finally
                {
                    Book_Load(null, null);
                }
            }
            else
            {
                Library.sqlConnection.Close();
            }
        }

        private void dataGridView_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                try
                {
                    Library.sqlConnection.Open();
                }
                catch (Exception ex)
                {
                    Library.sqlConnection.Close();
                    MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                    return;
                }
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM `library` l " +
                    "INNER JOIN `books` b ON l.`Id_book` = b.`Id_Book` WHERE " +
                    "l.`Id_book` = '" + dataGridView_books.Rows[dataGridView_books.CurrentCell.RowIndex].Cells[0].Value + "';", Library.sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    Library.sqlConnection.Close();
                    MessageBox.Show("You can't delete this book\n" +
                        "Someone borrow book",
                        "Attention");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure to DELETE this book?",
                   "DELETE book",
                   MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlCommand = new MySqlCommand("DELETE FROM books WHERE books.Id_Book = '" +
                        Convert.ToInt16(dataGridView_books.Rows[dataGridView_books.CurrentCell.RowIndex].Cells[0].Value) + "'",
                        Library.sqlConnection);
                    try
                    {
                        sqlCommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Library.sqlConnection.Close();
                        MessageBox.Show("Network connection error or false data\n" + ex, "ERROR");
                        return;
                    }
                }
                Library.sqlConnection.Close();
                Book_Load(null, null);
            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                try
                {
                    Library.sqlConnection.Open();
                }
                catch (Exception ex)
                {
                    Library.sqlConnection.Close();
                    MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                    return;
                }
                MySqlCommand sqlCommand = new MySqlCommand("SELECT COUNT(Id_Book) FROM books", Library.sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                row_count = 0;
                if (reader.Read())
                {
                    row_count = Convert.ToInt16(reader.GetValue(0));
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Please contact with us to solve this problem\n" +
                        "helpdeskIT@contact.pl or 555-666-777",
                        "Database is empty");
                    Library.sqlConnection.Close();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure to UPDATE this book?",
                    "Add new customer",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Update_book update_book = new Update_book();
                    update_book.ShowDialog();
                    if (Update_Name == "")
                    {
                        MessageBox.Show("You cannot update with empty data", "Attention!");
                        return;
                    }
                    else
                    {
                        string id = dataGridView_books.Rows[Convert.ToInt16(dataGridView_books.CurrentCell.RowIndex)].Cells[0].Value.ToString();
                        sqlCommand = new MySqlCommand("UPDATE `books` SET `Name` = '" +
                            Update_Name + "', `Last name` = '" +
                            Update_Last_name + "', `Title` = '" +
                            Update_Title + "', `Count` = '" +
                            Update_Count + "' WHERE `books`.`Id_Book` = " +
                             id + ";", Library.sqlConnection);
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Problem with server or data!\n"+ex, "Attention!");
                        }
                        finally
                        {
                            Update_Name = "";
                            Update_Last_name = "";
                            Update_Title = "";
                            Update_Count = "";
                        }
                    }
                    Library.sqlConnection.Close();
                    Book_Load(null, null);
                }
                else
                {
                    Library.sqlConnection.Close();
                }
            }
        }

        private void comboBox_name_DropDown(object sender, EventArgs e)
        {
            comboBox_name.Items.Clear();
            try
            {
                Library.sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Library.sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return;
            }
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `Name` FROM books ORDER BY `Id_Book`", Library.sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
            }
            else
            {
                reader.Close();
                Library.sqlConnection.Close();
                MessageBox.Show("Please contact with us to solve this problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777",
                    "Database is empty");
                return;
            }
            int j = 0;
            while (row_count > j)
            {
                comboBox_name.Items.Add(dataGridView_books.Rows[j].Cells[1].Value);
                j++;
            }
            Library.sqlConnection.Close();
        }

        private void comboBox_last_name_DropDown(object sender, EventArgs e)
        {
            comboBox_last_name.Items.Clear();
            try
            {
                Library.sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Library.sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return;
            }
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `Last name` FROM books ORDER BY `Id_Book`", Library.sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
            }
            else
            {
                reader.Close();
                Library.sqlConnection.Close();
                MessageBox.Show("Please contact with us to solve this problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777",
                    "Database is empty");
                return;
            }
            int j = 0;
            while (row_count > j)
            {
                comboBox_last_name.Items.Add(dataGridView_books.Rows[j].Cells[2].Value);
                j++;
            }
            Library.sqlConnection.Close();
        }
    }
}