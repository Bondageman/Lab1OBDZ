using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1OBDZ
{
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(h.ConStr))
            {
                //читаємо дані з форми FormAddRecordToTable
                string tb1 = textBox1.Text;
                string tb2 = textBox2.Text;
                string tb3 = textBox3.Text;
                string tb4 = textBox4.Text;
                string tb5 = textBox5.Text;

                //формуємо команду на додавання запису
                string sql = "INSERT INTO weapon " +
                             "(idWeapon, Weapon_Name, Weapon_Calibre, Weapon_Type, Weapon_Estimated_Range) " +
                             "VALUES (@TK1, @TK2, @TK3, @TK4, @TK5)";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                //додаємо параметри у колекцію класу Command
                cmd.Parameters.AddWithValue("@TK1", tb1);
                cmd.Parameters.AddWithValue("@TK2", tb2);
                cmd.Parameters.AddWithValue("@TK3", tb3);
                cmd.Parameters.AddWithValue("@TK4", tb4);
                cmd.Parameters.AddWithValue("@TK5", tb5);

                con.Open();           //Відкриваємо з'єднання
                cmd.ExecuteNonQuery(); //Виконуємо команду cmd
                con.Close();          //Закриваємо з'єднання

                MessageBox.Show("Додавання запису пройшло вдало");
            }
            this.Close(); //Закриваємо вікно
        }
    }
}
