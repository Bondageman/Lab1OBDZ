﻿using System;
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
    public partial class DeleteInfo : Form
    {
        public DeleteInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //формуємо запит на видалення з таблиці
            string sqlStr = "DELETE FROM weapon WHERE " + textBox1.Text;

            if (MessageBox.Show("Ви впевнені, що хочете видалити запис", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection con = new MySqlConnection(h.ConStr))
                {
                    MySqlCommand cmd = new MySqlCommand(sqlStr, con);

                    con.Open();           //Відкриваємо з'єднання
                    cmd.ExecuteNonQuery(); //Виконуємо команду cmd
                    con.Close();          //Закриваємо з'єднання
                }
                this.Close(); //Закриваємо вікно
            }
        }

        private void DeleteInfo_Load(object sender, EventArgs e)
        {
            textBox1.Text = h.keyName + " = " + h.curVa10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
