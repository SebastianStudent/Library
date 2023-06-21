using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public class CheckCorrect
    {
        public bool IsEmptyTextBox(string text)
        {
            if (text.Replace(" ", String.Empty) == String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmptyComboBox(ComboBox comboBox)
        {
            if (comboBox.Text.Replace(" ",String.Empty) == String.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool FalseName(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if ( !( (Convert.ToInt16(text[i]) >= 65 && Convert.ToInt16(text[i]) <= 90) ||
                    (Convert.ToInt16(text[i]) >= 97 && Convert.ToInt16(text[i]) <= 122)  ||
                    PolishAsciiTable(text[i])))
                {
                    return true;
                }
            }
            return false;
        }
        public bool FalseLastName(string text)
        {
            bool Hyphen_minus = true;
            for (int i = 0; i < text.Length; i++)
            {
                if (Convert.ToInt16(text[i]) == 45 && 
                    i != 0 && 
                    i != text.Length -1 &&
                    Hyphen_minus)
                {
                    Hyphen_minus = false;
                    continue;
                } 
                else if (!((Convert.ToInt16(text[i]) >= 65 && Convert.ToInt16(text[i]) <= 90) ||
                    (Convert.ToInt16(text[i]) >= 97 && Convert.ToInt16(text[i]) <= 122) ||
                    PolishAsciiTable(text[i])))
                {
                    return true;
                }
            }
            return false;
        }
        private bool PolishAsciiTable(char letter)
        {
            switch (letter)
            {
                case 'Ą':
                    return true;
                    break;
                case 'Ć':
                    return true;
                    break;
                case 'Ę':
                    return true;
                    break;
                case 'Ł':
                    return true;
                    break;
                case 'Ń':
                    return true;
                    break;
                case 'Ó':
                    return true;
                    break;
                case 'Ś':
                    return true;
                    break;
                case 'Ź':
                    return true;
                    break;
                case 'Ż':
                    return true;
                    break;
                case 'ą':
                    return true;
                    break;
                case 'ć':
                    return true;
                    break;
                case 'ę':
                    return true;
                    break;
                case 'ł':
                    return true;
                    break;
                case 'ń':
                    return true;
                    break;
                case 'ó':
                    return true;
                    break;
                case 'ś':
                    return true;
                    break;
                case 'ź':
                    return true;
                    break;
                case 'ż':
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
        }
        public bool FalseDateOfBirth(DateTime selectedTime, DateTime TodayDate)
        {
            if (selectedTime > TodayDate)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool FalseDeliveryDate(DateTime selectedTime, DateTime TodayDate)
        {
            if (selectedTime > TodayDate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool FalsePlusNumber(string number)
        {
            try
            {
                int plusnumber = Int16.Parse(number);
                if (plusnumber <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return true;
            }
        }
        public bool FalseBorrowCount(string name, string last_name, string title, string count)
        {
            try
            {
                Library.sqlConnection.Open();
            }
            catch (Exception ex)
            {
                Library.sqlConnection.Close();
                MessageBox.Show("ERROR SERVER CONNECTION\n" + ex);
                return true;
            }
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `Count` FROM `books` WHERE " +
                "`Name` LIKE '" + name +
                "' AND `Last name` LIKE '" + last_name + 
                "' AND `Title` LIKE '" + title + "';", Library.sqlConnection);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            int sqlcount = 0;
            if (reader.Read())
            {
                sqlcount = Convert.ToInt16(reader.GetString("Count"));
                reader.Close();
            }
            else
            {
                reader.Close();
                Library.sqlConnection.Close();
                MessageBox.Show("Please contact with us to solve this problem\n" +
                    "helpdeskIT@contact.pl or 555-666-777",
                    "Database is empty");
                return true;
            }
            if (Convert.ToInt16(count) > sqlcount)
            {
                Library.sqlConnection.Close();
                return true;
            }
            Library.current_count = sqlcount;
            Library.sqlConnection.Close();
            return false;
        }
        public string CorrectName(string text)
        {
            text = text.Trim();
            char FirstLetter = text[0];
            text.ToLower();
            text = FirstLetter.ToString().ToUpper() + text.Remove(0,1);
            return text;
        }
        public string CorrectLastName(string text)
        {
            text = text.Trim();
            char[] textArray = new char[text.Length];
            textArray = text.ToCharArray();
            text = "";
            for (int i = 0; i < textArray.Length; i++)
            {
                if (i == 0)
                {
                    textArray[i] = Convert.ToChar(textArray[i].ToString().ToUpper());
                }
                else if (Convert.ToInt16(textArray[i-1]) == 45)
                {
                    textArray[i] = Convert.ToChar(textArray[i].ToString().ToUpper());
                }
                else
                {
                    textArray[i] = Convert.ToChar(textArray[i].ToString().ToLower());
                }
                text += textArray[i];
            }
            return text;
        }
        public string DeleteWhiteSpace(string text)
        {
            return text.Replace(" ", String.Empty);
        }
    }
}
