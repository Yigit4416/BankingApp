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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void yeniHesapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newAccount newacc = new newAccount();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.MdiParent = this;
            updateForm.Show();
        }

        private void tümHesaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllAccounts allAccounts = new AllAccounts();
            allAccounts.MdiParent = this;
            allAccounts.Show();
        }

        private void paraEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm();
            depositForm.MdiParent = this;
            depositForm.Show();
            
        }

        private void paraÇekmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebitForm debitForm = new DebitForm();
            debitForm.MdiParent = this;
            debitForm.Show();
        }

        private void bilançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BalanceSheet balanceSheet = new BalanceSheet();
            balanceSheet.MdiParent = this;
            balanceSheet.Show();
        }

        private void fDGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDGoruntule fDGoruntule = new FDGoruntule();
            fDGoruntule.MdiParent = this;
            fDGoruntule.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordChange passwordChange = new PasswordChange();
            passwordChange.MdiParent = this;
            passwordChange.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferForm transferForm = new TransferForm();
            transferForm.MdiParent = this;
            transferForm.Show();
        }

        private void fDFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDView fDView = new FDView();
            fDView.MdiParent = this;
            fDView.Show();
        }
    }
}
