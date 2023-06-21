using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library
{
    public partial class Library : Form
    {
        public static MySqlConnection sqlConnection;
        public static bool serverERROR = false;
        CheckCorrect checkCorrectClass = new CheckCorrect();
        public static string delivery_date = "";
        public static int current_count;
        public Library()
        {
            InitializeComponent();
        }
        private void Library_Load(object sender, EventArgs e)
        {
            Reset();
            serverERROR = false;
            sqlConnection = new MySqlConnection("Datasource = 127.0.0.1; username = root; password =; Database=library");
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                serverERROR = true;
                sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return;
            }
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `Name` FROM `customer`;", sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            try
            {
                int index = 0;
                ArrayList arrayNameAndLastName = new ArrayList();
                while (reader.Read())
                {
                    arrayNameAndLastName.Add(reader.GetString("Name"));
                    index++;
                }
                reader.Close();
                index = 0;
                sqlCommand = new MySqlCommand("SELECT `Last name` FROM `customer`;", sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    arrayNameAndLastName[index] = arrayNameAndLastName[index] + " " + reader.GetString("Last name");
                    index++;
                }
                reader.Close();
                index = 0;
                comboBox_customer.Items.AddRange(arrayNameAndLastName.ToArray());
                sqlCommand = new MySqlCommand("SELECT `Name` FROM `books`;", sqlConnection);
                reader = sqlCommand.ExecuteReader();
                arrayNameAndLastName = new ArrayList();
                while (reader.Read())
                {
                    arrayNameAndLastName.Add(reader.GetString("Name"));
                    index++;
                }
                reader.Close();
                index = 0;
                sqlCommand = new MySqlCommand("SELECT `Last name` FROM `books`;", sqlConnection);
                reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    arrayNameAndLastName[index] = arrayNameAndLastName[index] + " " + reader.GetString("Last name");
                    index++;
                }
                reader.Close();
                comboBox_author.Items.AddRange(arrayNameAndLastName.ToArray());
            }
            catch
            {
                reader.Close();
                MessageBox.Show("Please contact with us to solve this problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777",
                    "Database is empty");
                sqlConnection.Close();
                return;
            }
            sqlCommand = new MySqlCommand("SELECT l.`Id`,l.`Id_customer`,l.`Id_book`,c.`Name` AS `Name Customer`,c.`Last name` AS `Last name Customer`,c.`Date of birth`,b.`Name` AS `Name author`,b.`Last name` AS `Last name author`,b.`Title`,l.`Count of borrow`,l.`Delivery date` " +
                "FROM `library` l " +
                "INNER JOIN `customer` c ON l.`Id_customer` = c.`Id_customer` " +
                "INNER JOIN `books` b ON l.`Id_book` = b.`Id_Book` " +
                "ORDER BY l.`Id`;", sqlConnection);
            reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                reader.Close();
            }
            else
            {
                reader.Close();
                sqlConnection.Close();
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
                dataGridView_library.DataSource = dataTable.DefaultView;
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show("Click button REFRESH application or contact with us to solve your problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777\n\n" + ex,
                    "ERROR with data!");
            }
            sqlConnection.Close();
            foreach (DataGridViewColumn column in dataGridView_library.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            MonthCalendar monthCalendar = new MonthCalendar();

            string current_date = monthCalendar.TodayDate.ToShortDateString();
            string current_year = current_date.Substring(6, 4);
            string current_month = current_date.Substring(3, 2);
            string current_day = current_date.Substring(0, 2);
            foreach (DataGridViewRow row in dataGridView_library.Rows)
            {
                string delivery_date = dataGridView_library.Rows[row.Index].Cells[10].Value.ToString();
                string delivery_year = delivery_date.Substring(6, 4);
                string delivery_month = delivery_date.Substring(3, 2);
                string delivery_day = delivery_date.Substring(0, 2);
                if ( Convert.ToInt16(current_year) > Convert.ToInt16(delivery_year))
                {
                    row.DefaultCellStyle.BackColor = Color.Tomato;
                    continue;
                }
                if (Convert.ToInt16(current_year) == Convert.ToInt16(delivery_year))
                {
                    if (Convert.ToInt16(current_month) > Convert.ToInt16(delivery_month))
                    {
                        row.DefaultCellStyle.BackColor = Color.Tomato;
                        continue;
                    }
                }
                if (Convert.ToInt16(current_year) == Convert.ToInt16(delivery_year))
                {
                    if (Convert.ToInt16(current_month) == Convert.ToInt16(delivery_month))
                    {
                        if (Convert.ToInt16(current_day) >= Convert.ToInt16(delivery_day))
                        {
                            row.DefaultCellStyle.BackColor = Color.Tomato;
                            continue;
                        }
                    }
                }

            }
        }
        private void button_customer_Click(object sender, EventArgs e)
        {
            if (serverERROR)
            {
                MessageBox.Show("Without a database connection, you cannot enter new data",
                    "Attention!");
                return;
            }
            Customer insert_new_customer = new Customer();
            insert_new_customer.ShowDialog();
            Library_Load(null, null);
        }
        private void button_book_Click(object sender, EventArgs e)
        {
            if (serverERROR)
            {
                MessageBox.Show("Without a database connection, you cannot enter new data",
                    "Attention!");
                return;
            }
            Book insert_new_book = new Book();
            insert_new_book.ShowDialog();
            Library_Load(null, null);
        }
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_reset_Click(object sender, EventArgs e)
        {
            Library_Load(null, null);
        }

        private void comboBox_customer_DropDownClosed(object sender, EventArgs e)
        {
            comboBox_customer_date_of_birth.Items.Clear();
            if (comboBox_customer.SelectedIndex == -1)
            {
                comboBox_customer_date_of_birth.Enabled = false;
                return;
            }
            comboBox_customer_date_of_birth.Enabled = true;
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                serverERROR = true;
                sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return;
            }
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `Date of birth` FROM `customer` WHERE " +
                "`Name` LIKE '" + NameFind(comboBox_customer.SelectedItem.ToString()) +
                "' AND `Last name` LIKE '" + Last_NameFind(comboBox_customer.SelectedItem.ToString()) + "';", sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBox_customer_date_of_birth.Items.Add(reader.GetString("Date of birth"));
            }
            reader.Close();
            sqlConnection.Close();
        }
        private void comboBox_author_DropDownClosed(object sender, EventArgs e)
        {
            comboBox_author_title.Items.Clear();
            if (comboBox_author.SelectedIndex == -1)
            {
                comboBox_author_title.Enabled = false;
                return;
            }
            comboBox_author_title.Enabled = true;
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                serverERROR = true;
                sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return;
            }
            string name = NameFind(comboBox_author.SelectedItem.ToString());
            string last_name = Last_NameFind(comboBox_author.SelectedItem.ToString());
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `Title` FROM `books` WHERE " +
                "`Name` LIKE '" + name +
                "' AND `Last name` LIKE '" + last_name + "';", sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBox_author_title.Items.Add(reader.GetString("Title"));
            }
            reader.Close();
            sqlConnection.Close();
        }
        private string NameFind(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            int spaceIndex = text.IndexOf(" ");
            sb.Remove(spaceIndex, text.Length - spaceIndex);
            return sb.ToString();
        }
        private string Last_NameFind(string text)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            int spaceIndex = text.IndexOf(" ");
            sb.Remove(0, spaceIndex + 1);
            return sb.ToString();
        }
        private void button_new_borrow_Click(object sender, EventArgs e)
        {
            if (comboBox_customer.SelectedIndex == -1)
            {
                MessageBox.Show("Select customer", "Empty space!");
                return;
            }
            else if (comboBox_customer_date_of_birth.SelectedIndex == -1)
            {
                MessageBox.Show("Select customer date of birth", "Empty space!");
                return;
            }
            else if (comboBox_author.SelectedIndex == -1)
            {
                MessageBox.Show("Select author", "Empty space!");
                return;
            }
            else if (comboBox_author_title.SelectedIndex == -1)
            {
                MessageBox.Show("Select title of book", "Empty space!");
                return;
            }
            else if (checkCorrectClass.IsEmptyTextBox(textBox_count.Text))
            {
                MessageBox.Show("Count of borrow book is empty", "Empty space!");
                return;
            }
            else if (checkCorrectClass.FalsePlusNumber(textBox_count.Text))
            {
                MessageBox.Show("Incorrect data in Count\nOr\nYou cannot add zero or less number", "Attention!");
                return;
            }
            else if (checkCorrectClass.FalseBorrowCount(NameFind(comboBox_author.SelectedItem.ToString()),
                Last_NameFind(comboBox_author.SelectedItem.ToString()),
                comboBox_author_title.SelectedItem.ToString(),
                textBox_count.Text))
            {
                MessageBox.Show("You can't borrow that number of books", "Attention!");
                return;
            }
            textBox_count.Text = checkCorrectClass.DeleteWhiteSpace(textBox_count.Text);
            Library_deliveryDate library_DeliveryDate = new Library_deliveryDate();
            library_DeliveryDate.ShowDialog();
            if (delivery_date == "")
            {
                MessageBox.Show("You cannot update with empty data", "Attention!");
                return;
            }
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                serverERROR = true;
                sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you sure to BORROW book to this customer?",
                    "Add new borrow",
                    MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MySqlCommand sqlCommand = new MySqlCommand("SELECT COUNT(Id) FROM library", sqlConnection);
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                int idCount = 0;
                if (reader.Read())
                {
                    idCount = Convert.ToInt16(reader.GetValue(0));
                    reader.Close();
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Problem with sql query",
                        "ERROR");
                    Library.sqlConnection.Close();
                    return;
                }
                for (int library_index = 1; library_index <= idCount + 1; library_index++)
                {
                    sqlCommand = new MySqlCommand("SELECT `Id` FROM `library` WHERE `library`.`Id` = " + library_index + ";", sqlConnection);
                    reader = sqlCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        int bookID;
                        int customerID;
                        sqlCommand = new MySqlCommand("SELECT `Id_Book` FROM `books` WHERE " +
                            "`Name` LIKE '" + NameFind(comboBox_author.SelectedItem.ToString()) + "'" +
                            "AND `Last name` LIKE '" + Last_NameFind(comboBox_author.SelectedItem.ToString()) + "'" +
                            "AND `Title` LIKE '" + comboBox_author_title.SelectedItem.ToString() + "';", sqlConnection);
                        reader = sqlCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            bookID = Convert.ToInt32(reader.GetValue(0));
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Problem with sql query in books",
                                "SERVER ERROR");
                            Library.sqlConnection.Close();
                            return;
                        }
                        sqlCommand = new MySqlCommand("SELECT `Id_customer` FROM `customer` WHERE " +
                            "`Name` LIKE '" + NameFind(comboBox_customer.SelectedItem.ToString()) + "'" +
                            "AND `Last name` LIKE '" + Last_NameFind(comboBox_customer.SelectedItem.ToString()) + "'" +
                            "AND `Date of birth` LIKE '" + comboBox_customer_date_of_birth.SelectedItem.ToString() + "';", sqlConnection);
                        reader = sqlCommand.ExecuteReader();
                        if (reader.Read())
                        {
                            customerID = Convert.ToInt32(reader.GetValue(0));
                            reader.Close();
                        }
                        else
                        {
                            reader.Close();
                            MessageBox.Show("Problem with sql query in customer",
                                "SERVER ERROR");
                            Library.sqlConnection.Close();
                            return;
                        }
                        sqlCommand = new MySqlCommand("INSERT INTO `library` (`Id`,`Id_customer`,`Id_book`,`Count of borrow`,`Delivery date`) " +
                            "VALUES('" + library_index + "'," +
                            "'" + customerID + "'," +
                            "'" + bookID + "'," +
                            "'" + textBox_count.Text.ToString() + "'," +
                            "'" + delivery_date + "')" +
                            ";", sqlConnection);
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
                        sqlCommand = new MySqlCommand("UPDATE `books` SET Count = " +
                            "'" + (current_count - Convert.ToInt16(textBox_count.Text.ToString())) + "' " +
                            "WHERE Id_Book = '" + bookID + "';", sqlConnection);
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch
                        {
                            MessageBox.Show("Please contact with us to solve this problem\n" +
                                "helpdeskIT@contact.pl or 555-666-777",
                                "Database is empty");
                            Library.sqlConnection.Close();
                            return;
                        }
                        MessageBox.Show("Successfully CREATE new borror and UPDATE book data", "Success");
                        break;
                    }
                }
                Reset();
                Library.sqlConnection.Close();
                Library_Load(null, null);
            }
            else
            {
                Library.sqlConnection.Close();
            }
        }
        private void Reset()
        {
            textBox_count.Text = "";
            comboBox_customer.Items.Clear();
            comboBox_customer_date_of_birth.Items.Clear();
            comboBox_author.Items.Clear();
            comboBox_author_title.Items.Clear();
            comboBox_customer.SelectedIndex = -1;
            comboBox_customer_date_of_birth.SelectedIndex = -1;
            comboBox_author.SelectedIndex = -1;
            comboBox_author_title.SelectedIndex = -1;
            comboBox_customer_date_of_birth.Enabled = false;
            comboBox_author_title.Enabled = false;
        }

        private void dataGridView_library_KeyPress(object sender, KeyPressEventArgs e)
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
                DialogResult dialogResult = MessageBox.Show("Are you sure to DELETE this record of borrow book?",
                   "DELETE customer",
                   MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MySqlCommand sqlCommand = new MySqlCommand("SELECT `Count` FROM `books` WHERE `Id_Book` = " +
                        dataGridView_library.Rows[dataGridView_library.CurrentCell.RowIndex].Cells[2].Value + ";", sqlConnection);
                    MySqlDataReader reader = sqlCommand.ExecuteReader();
                    int count_update = 0;
                    if (reader.Read())
                    {
                        count_update = reader.GetInt32(0);
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
                    sqlCommand = new MySqlCommand("UPDATE `books` SET `Count` = '" +
                        (count_update + Convert.ToInt16(dataGridView_library.Rows[dataGridView_library.CurrentCell.RowIndex].Cells[9].Value)) +
                        "' WHERE `books`.`Id_Book` = " +
                        dataGridView_library.Rows[dataGridView_library.CurrentCell.RowIndex].Cells[2].Value + ";", sqlConnection);
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
                    sqlCommand = new MySqlCommand("DELETE FROM library WHERE library.Id = '" +
                        Convert.ToInt16(dataGridView_library.Rows[dataGridView_library.CurrentCell.RowIndex].Cells[0].Value) + "'",
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
                Library_Load(null, null);
            }
        }
    }
}
