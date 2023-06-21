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
    public partial class Update_customer : Form
    {
        CheckCorrect checkCorrectClass = new CheckCorrect();
        public Update_customer()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_customer_Click(object sender, EventArgs e)
        {
            if (checkCorrectClass.IsEmptyTextBox(textBox_name.Text.ToString()) ||
                checkCorrectClass.IsEmptyTextBox(textBox_last_name.Text.ToString()))
            {
                MessageBox.Show("You cannot add empty date",
                    "Attention!");
                return;
            }
            if (checkCorrectClass.FalseName(textBox_name.Text.ToString()))
            {
                MessageBox.Show("Incorrect name",
                    "Attention!");
                return;
            }
            if (checkCorrectClass.FalseLastName(textBox_last_name.Text.ToString()))
            {
                MessageBox.Show("Incorrect last name",
                    "Attention!");
                return;
            }
            if (checkCorrectClass.FalseDateOfBirth(monthCalendar_date_of_birth.SelectionStart, monthCalendar_date_of_birth.TodayDate))
            {
                MessageBox.Show("You cannot add that date of birth",
                    "Attention!");
                return;
            }
            string CorrectName = checkCorrectClass.CorrectName(textBox_name.Text.ToString());
            string CorrectLastName = checkCorrectClass.CorrectLastName(textBox_last_name.Text.ToString());
            Customer.Update_Name = CorrectName;
            Customer.Update_Last_name = CorrectLastName;
            Customer.Update_Date_of_birth = monthCalendar_date_of_birth.SelectionStart.ToShortDateString();
            this.Close();
        }
    }
}
