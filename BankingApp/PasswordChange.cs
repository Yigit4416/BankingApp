using System;
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
    public partial class PasswordChange : Form
    {
        public PasswordChange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            int idNo = 1;
            var item = (from i in dbe.Admin_Table where i.Id == idNo select i).FirstOrDefault();

            if(usernametext.Text.Length > 0 )
            {
                item.Username = usernametext.Text;
                dbe.SaveChanges();
                MessageBox.Show("Kullanıcı adı değiştirildi");
            }
            if(oldpasstext.Text == item.Password)
            {
                if(newpasstext.Text == item.Password)
                {
                    MessageBox.Show("Lütfen farklı bir şifre seçin");
                }
                else if(newpasstext.Text == newagaintext.Text)
                {
                    item.Password = newagaintext.Text;
                    dbe.SaveChanges();
                    MessageBox.Show("Şifre değiştirildi");
                }
                else
                {
                    MessageBox.Show("Şifreler uyuşmuyor");
                }
            }
        }
    }
}
