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
    public partial class FDView : Form
    {
        private BackgroundWorker worker;

        public FDView()
        {
            InitializeComponent();
            loaddate();
            loadmode();
            InitializeBackgrounWorker();
        }

        private void InitializeBackgrounWorker()
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
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
            MessageBox.Show("Vade başlatıldı\n" + fd.Maturity_Date + " tarihinde" + fd.Maturiyt_Amount + " TL'nizi alabilirsiniz.");
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            FD fd = (FD)e.Argument;
            DateTime maturityDate = DateTime.Parse(fd.Maturity_Date);

            while(DateTime.UtcNow <  maturityDate)
            {
                System.Threading.Thread.Sleep(1000 * 60 * 60); // Saat başı kontrol edilmesini sağlayacak
            }

            // Faizli para hesaba geri yansıtılır
            using (banking_dbEntities1 dbe = new banking_dbEntities1())
            {
                var account = dbe.userAccount.Where(i => i.Account_No == fd.Account_No).SingleOrDefault();
                if(account != null)
                {
                    account.Balance += fd.Maturiyt_Amount;
                    dbe.SaveChanges();
                }
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Maturity amount has been credited back to the account.");
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(accountnotext.Text);
            var item = dbe.userAccount.Where(i => i.Account_No == accno).SingleOrDefault();
            if(item != null)
            {
                balancetext.Text = item.Balance.ToString();
            }
            else
            {
                MessageBox.Show("Böyle bir hesap yok");
            }
        }

        private void getinfobutton_Click(object sender, EventArgs e)
        {
            string sonTarih = (DateTime.UtcNow.AddDays(Convert.ToInt32(timetext.Text))).ToString("dd/MM/yyyy");
            int alinacakPara = Convert.ToInt32(((Convert.ToDecimal(liratext.Text) * Convert.ToInt32(timetext.Text) * Convert.ToDecimal(interesttext.Text)) / (100 * 12 * 30)) + Convert.ToDecimal(liratext.Text));
            MessageBox.Show(sonTarih + " tarihinde alınacak para: " + alinacakPara + "TL");
        }
    }
}
