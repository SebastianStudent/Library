using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Update_book : Form
    {
        CheckCorrect checkCorrectClass = new CheckCorrect();
        public Update_book()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_book_Click(object sender, EventArgs e)
        {
            if (checkCorrectClass.IsEmptyTextBox(textBox_name.Text.ToString()) ||
               checkCorrectClass.IsEmptyTextBox(textBox_last_name.Text.ToString()) ||
               checkCorrectClass.IsEmptyTextBox(textBox_title.Text.ToString()) ||
               checkCorrectClass.IsEmptyTextBox(textBox_count.Text.ToString()))
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
            if (checkCorrectClass.FalsePlusNumber(textBox_count.Text.ToString()))
            {
                MessageBox.Show("Incorrect data in Count\nOr\nYou cannot add zero or less number",
                    "Attention!");
                Library.sqlConnection.Close();
                return;
            }
            string CorrectName = checkCorrectClass.CorrectName(textBox_name.Text.ToString());
            string CorrectLastName = checkCorrectClass.CorrectLastName(textBox_last_name.Text.ToString());
            string Title = textBox_title.Text.ToString();
            string Count = checkCorrectClass.DeleteWhiteSpace(textBox_count.Text.ToString());
            Book.Update_Name = CorrectName;
            Book.Update_Last_name = CorrectLastName;
            Book.Update_Title = Title;
            Book.Update_Count = Count;
            this.Close();
        }
    }
}
