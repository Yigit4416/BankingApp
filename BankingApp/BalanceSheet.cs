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
    public partial class BalanceSheet : Form
    {
        public BalanceSheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(accnotext.Text);
            var item = (from i in dbe.userAccount where i.Account_No == accno select i).FirstOrDefault();
            if(item != null )
            {
            var withdraw = (from i in dbe.debit where i.AccountNo == accno  select i);
            dataGridView1.DataSource = withdraw.ToList();

            var deposit = (from i in dbe.Deposit where i.AccountNo == accno select i);
            dataGridView2.DataSource = deposit.ToList();

            var fd = (from i in dbe.FD where i.Account_No == accno select i);
            dataGridView3.DataSource = fd.ToList();
            }

            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok");
            }
        }
    }
}
