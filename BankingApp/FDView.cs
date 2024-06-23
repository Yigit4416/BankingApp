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

    // TODO: belli tarihten osnra toplam değeri hesaba geri yansıt.
{
    public partial class FDView : Form
    {
        public FDView()
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
            currentdatelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(accountnotext.Text);
            var accounts = dbe.userAccount.Where(i => i.Account_No == accno).SingleOrDefault();
            FD fd = new FD();
            fd.Account_No = Convert.ToDecimal(accountnotext.Text);
            fd.Mode = comboBox1.SelectedItem.ToString();
            fd.Lira = liratext.Text;
            fd.Period = Convert.ToInt32(timetext.Text);
            fd.Interest_rate = Convert.ToDecimal(interesttext.Text);
            fd.Start_Date = currentdatelbl.Text;
            fd.Maturity_Date = (DateTime.UtcNow.AddDays(Convert.ToInt32(timetext.Text))).ToString();
            fd.Maturiyt_Amount = Convert.ToDecimal(Convert.ToInt32(((Convert.ToDecimal(liratext.Text) * Convert.ToInt32(timetext.Text) * Convert.ToDecimal(interesttext.Text)) / (100 * 12 * 30)) + Convert.ToDecimal(liratext.Text)));
            
            var snocounter = dbe.FD.ToArray();
            int no = snocounter.LastOrDefault().sno + 1;
            fd.sno = no;

            decimal amount = Convert.ToDecimal(liratext.Text);
            decimal totalamount = Convert.ToDecimal(accounts.Balance);
            decimal fdbalance = totalamount - amount;
            accounts.Balance = fdbalance;

            dbe.FD.Add(fd);
            dbe.SaveChanges();
            MessageBox.Show("Vade başlatıldı");
        }
    }
}
