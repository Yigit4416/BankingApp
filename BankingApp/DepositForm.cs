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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            comboBox1.Items.Add("Nakit");
            comboBox1.Items.Add("Çek");
        }

        private void loaddate()
        {
            currentDate.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            newAccount acc = new newAccount();
            Deposit deposit = new Deposit();

            deposit.Date = currentDate.Text;
            deposit.AccountNo = Convert.ToDecimal(accnotext.Text);
            deposit.Name = nametext.Text;
            deposit.OldBalance = Convert.ToDecimal(balance.Text);
            deposit.Mode = comboBox1.SelectedItem.ToString();
            deposit.DipAmount = Convert.ToDecimal(addedAmount.Text);

            dbe.Deposit.Add(deposit);
            dbe.SaveChanges();

            decimal b = Convert.ToDecimal(accnotext.Text);
            var item = (from u in dbe.userAccount 
                        where u.Account_No == b
                        select u).FirstOrDefault();
            item.Balance =  item.Balance + Convert.ToDecimal(addedAmount.Text);
            dbe.SaveChanges();
            MessageBox.Show("Ekleme yapıldı");
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal b = Convert.ToDecimal(accnotext.Text);
            var item = (from u in dbe.userAccount where u.Account_No == b select u).FirstOrDefault();

            nametext.Text = item.Name;
            balance.Text = Convert.ToString(item.Balance);

        }
    }
}
