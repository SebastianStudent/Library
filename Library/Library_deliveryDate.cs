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
    public partial class Library_deliveryDate : Form
    {
        CheckCorrect checkCorrectClass = new CheckCorrect();
        public Library_deliveryDate()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_delivery_date_Click(object sender, EventArgs e)
        {
            if (checkCorrectClass.FalseDeliveryDate(monthCalendar_delivery_date.SelectionStart, monthCalendar_delivery_date.TodayDate))
            {
                MessageBox.Show("You cannot add that date of delivery.\n" +
                    "It should be after today date.",
                    "Attention!");
                return;
            }
            Library.delivery_date = monthCalendar_delivery_date.SelectionStart.ToShortDateString();
            this.Close();
        }
    }
}
