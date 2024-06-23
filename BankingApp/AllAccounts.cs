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
    public partial class AllAccounts : Form
    {
        public AllAccounts()
        {
            InitializeComponent();
            bindgrid();
        }

        private void bindgrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            banking_dbEntities1 bs = new banking_dbEntities1();
            var item = bs.userAccount.ToList();
            dataGridView1.DataSource = item;
        }
    }
}
