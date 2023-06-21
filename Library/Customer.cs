using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
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
    public partial class Customer : Form
    {
        CheckCorrect checkCorrectClass = new CheckCorrect();
        public static string Update_Name = "";
        public static string Update_Last_name = "";
        public static string Update_Date_of_birth;
        private static int row_count;
        public static int ColumnCount;
        public Customer()
        {
            InitializeComponent();
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_new_customer_Click(object sender, EventArgs e)
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
            if (checkCorrectClass.IsEmptyTextBox(textBox_name.Text.ToString()) ||
                checkCorrectClass.IsEmptyTextBox(textBox_last_name.Text.ToString()))
            {
                MessageBox.Show("You cannot add empty date",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            if (checkCorrectClass.FalseName(textBox_name.Text.ToString()))
            {
                MessageBox.Show("Incorrect name",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            if (checkCorrectClass.FalseLastName(textBox_last_name.Text.ToString()))
            {
                MessageBox.Show("Incorrect last name",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            if (checkCorrectClass.FalseDateOfBirth(monthCalendar_date_of_birth.SelectionStart, monthCalendar_date_of_birth.TodayDate))
            {
                MessageBox.Show("You cannot add that date of birth",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            string CorrectName = checkCorrectClass.CorrectName(textBox_name.Text.ToString());
            string CorrectLastName = checkCorrectClass.CorrectLastName(textBox_last_name.Text.ToString());
            DialogResult dialogResult = MessageBox.Show("Are you sure to CREATE this customer?\n" +
                CorrectName + " " +
                CorrectLastName + " " +
                monthCalendar_date_of_birth.SelectionStart.ToShortDateString(),
                "Add new customer",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Library.sqlConnection.Close();
                Customer_Load(null, null);
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
                MySqlCommand sqlCommand = new MySqlCommand("SELECT COUNT(Id_customer) FROM customer", Library.sqlConnection);
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
                    if (Convert.ToInt16(dataGridView_customer.Rows[i].Cells[0].Value) != (i + 1))
                    {
                        index = i + 1;
                        break;
                    }
                }
                if (index == 0)
                {
                    sqlCommand = new MySqlCommand("INSERT INTO `customer` (`Id_customer`, `Name`, `Last name`, `Date of birth`) " +
                        "VALUES('" + (row_count + 1) + "', '" +
                        CorrectName + "', '" +
                        CorrectLastName + "', '" +
                        monthCalendar_date_of_birth.SelectionStart.ToShortDateString() + "')",
                        Library.sqlConnection);
                }
                else
                {
                    sqlCommand = new MySqlCommand("INSERT INTO `customer` (`Id_customer`, `Name`, `Last name`, `Date of birth`) " +
                        "VALUES('" + index + "', '" +
                        CorrectName + "', '" +
                        CorrectLastName + "', '" +
                        monthCalendar_date_of_birth.SelectionStart.ToShortDateString() + "')",
                        Library.sqlConnection);
                }
                try
                {
                    sqlCommand.ExecuteNonQuery();
                    textBox_name.Text = "";
                    textBox_last_name.Text = "";
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
                    Customer_Load(null, null);
                }
            }
            else
            {
                Library.sqlConnection.Close();
            }
        }
        private void Customer_Load(object sender, EventArgs e)
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
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM customer ORDER BY Id_customer", Library.sqlConnection);
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
                dataGridView_customer.DataSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                Library.sqlConnection.Close();
                MessageBox.Show("Click button REFRESH application or contact with us to solve your problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777\n\n" + ex,
                    "ERROR with data!");
                return;
            }
            Library.sqlConnection.Close();
            foreach (DataGridViewColumn column in dataGridView_customer.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
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
                    "INNER JOIN `customer` c ON l.`Id_customer` = c.`Id_customer` WHERE " +
                    "l.`Id_customer` = '" + dataGridView_customer.Rows[dataGridView_customer.CurrentCell.RowIndex].Cells[0].Value + "';", Library.sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                if (reader.Read())
                {
                    reader.Close();
                    Library.sqlConnection.Close();
                    MessageBox.Show("You can't delete this customer\n" +
                        "This customer borrow book",
                        "Attention");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you sure to DELETE this customer?",
                   "DELETE customer",
                   MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sqlCommand = new MySqlCommand("DELETE FROM customer WHERE customer.Id_customer = '" +
                        Convert.ToInt16(dataGridView_customer.Rows[dataGridView_customer.CurrentCell.RowIndex].Cells[0].Value) + "'",
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
                Customer_Load(null, null);
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
                MySqlCommand sqlCommand = new MySqlCommand("SELECT COUNT(Id_customer) FROM customer", Library.sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                int row_count = 0;
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
                DialogResult dialogResult = MessageBox.Show("Are you sure to UPDATE this customer?",
                    "Add new customer",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Update_customer update_customer = new Update_customer();
                    update_customer.ShowDialog();
                    if (Update_Name == "")
                    {
                        MessageBox.Show("You cannot update with empty data", "Attention!");
                        return;
                    }
                    else
                    {
                        string id = dataGridView_customer.Rows[Convert.ToInt16(dataGridView_customer.CurrentCell.RowIndex)].Cells[0].Value.ToString();
                        sqlCommand = new MySqlCommand("UPDATE `customer` SET `Name` = '" +
                            Update_Name + "', `Last name` = '" +
                            Update_Last_name + "', `Date of birth` = '" +
                            Update_Date_of_birth + "' WHERE `customer`.`Id_customer` = " +
                             id + ";", Library.sqlConnection);
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Problem with server or data!", "Attention!");
                        }
                        finally
                        {
                            Update_Name = "";
                            Update_Last_name = "";
                            Update_Date_of_birth = "";
                        }
                    }
                    Library.sqlConnection.Close();
                    Customer_Load(null, null);
                }
                else
                {
                    Library.sqlConnection.Close();
                }
            }
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            Customer_Load(null, null);
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
            ColumnCount = dataGridView_customer.ColumnCount;
            if (checkedListBox_search_mode.GetItemChecked(0))
            {
                AtthebeginningSearch(ColumnCount,
                    dataGridView_customer.RowCount,
                    textBox_search.Text.ToString());
            }
            else if (checkedListBox_search_mode.SelectedItem.ToString() == "In the middle")
            {
                InthemiddleSearch(ColumnCount,
                    dataGridView_customer.RowCount,
                    textBox_search.Text.ToString());
            }
            else if (checkedListBox_search_mode.SelectedItem.ToString() == "At the end")
            {
                AttheendSearch(ColumnCount,
                    dataGridView_customer.RowCount,
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
                    string cell_value = dataGridView_customer.Rows[i].Cells[j].Value.ToString().ToLower();
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
                    dataGridView_customer.Rows.RemoveAt(i);
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
                    string cell_value = dataGridView_customer.Rows[i].Cells[j].Value.ToString().ToLower();
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
                    dataGridView_customer.Rows.RemoveAt(i);
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
                    string cell_value = dataGridView_customer.Rows[i].Cells[j].Value.ToString().ToLower();
                    if (cell_value.Length > text_lower.Length)
                    {
                        string cell_value_fragment = cell_value.Substring(cell_value.Length-text_lower.Length);
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
                    dataGridView_customer.Rows.RemoveAt(i);
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
    }
}