﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();

            if (usrtxt.Text != string.Empty || passtxt.Text != string.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.Username.Equals(usrtxt.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(passtxt.Text))
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı şifre");
                    }
                }
                else
                {
                    var user2 = dbe.Admin_Table.FirstOrDefault();
                    if (user2 != null)
                    {
                        MessageBox.Show("Kullanıcı adı hatalı");
                    }
                    else
                    {
                        user2 = new Admin_Table // Yeni bir kullanıcı oluşturuyoruz
                        {
                            Username = usrtxt.Text,
                            Password = passtxt.Text
                        };
                        dbe.Admin_Table.Add(user2);
                        dbe.SaveChanges();
                    }
                }
            }
            else
            {
                MessageBox.Show("Eksik değerleri doldur");
            }
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
