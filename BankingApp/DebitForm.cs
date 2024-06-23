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
    public partial class DebitForm : Form
    {
        public DebitForm()
        {
            InitializeComponent();
            comboload();
            laoddate();
        }

        private void laoddate()
        {
            currentdatetext.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void comboload()
        {
            comboBox1.Items.Add("Nakit");
            comboBox1.Items.Add("Çek");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(accnotext.Text);
            var item = (from i in dbe.userAccount where i.Account_No == accno select i).FirstOrDefault();
            
            if(item != null)
            {
            nametext.Text = item.Name;
            balancetext.Text = Convert.ToString(item.Balance);
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            newAccount acc = new newAccount();
            debit db = new debit();
            db.Date = currentdatetext.Text;
            db.AccountNo = Convert.ToDecimal(accnotext.Text);
            db.Name = nametext.Text;
            db.OldBalance = Convert.ToDecimal(balancetext.Text);
            db.Mode = comboBox1.SelectedItem.ToString();
            db.DebAmount = Convert.ToDecimal(amounttext.Text);

            dbe.debit.Add(db);
            dbe.SaveChanges();

            decimal accno = Convert.ToDecimal(accnotext.Text);
            var item = (from i in dbe.userAccount where i.Account_No == accno select i).FirstOrDefault();
            item.Balance -= Convert.ToDecimal(amounttext.Text);
            dbe.SaveChanges();
            MessageBox.Show("Para çekildi\n" + item.Account_No + " no'lu hesap nolu hesabın kalan bakiyesi: " + item.Balance);
        }
    }
}
