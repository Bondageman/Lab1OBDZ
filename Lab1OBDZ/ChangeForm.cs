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

namespace Lab1OBDZ
{
    public partial class ChangeForm : Form
    {
        public ChangeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlStr = "UPDATE weapon SET " + textBox1.Text +
                            " WHERE " + textBox2.Text;

            if (MessageBox.Show("Ви впевнені, що хочете замінити дані?", "Заміна",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(h.ConStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                    con.Open(); //Відкриваємо з'єднання
                    cmd.ExecuteNonQuery(); //Виконуємо команду cmd
                    con.Close(); //Закриваємо з'єднання
                }
            }
            this.Close(); //Закриваємо вікно
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
