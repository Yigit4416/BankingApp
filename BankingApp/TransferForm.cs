using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            currentdatelbl.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal senderacc = Convert.ToDecimal(sendacctext.Text);
            var item = (from i in dbe.userAccount where i.Account_No == senderacc select i).FirstOrDefault();

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

        private void button3_Click(object sender, EventArgs e)
        {
            banking_dbEntities1 dbe = new banking_dbEntities1();
            decimal senderacc = Convert.ToDecimal(sendacctext.Text);
            var item = (from i in dbe.userAccount where i.Account_No == senderacc select i).FirstOrDefault();
            decimal totalBalance = Convert.ToDecimal(balancetext.Text);
            decimal reciverAcc = Convert.ToDecimal(recivetext.Text);
            decimal amountSend = Convert.ToDecimal(amountsendtext.Text);
            if(item != null)
            {

                if(totalBalance > amountSend)
                {
                    var reciveritem = (from i in dbe.userAccount where i.Account_No == reciverAcc select i).FirstOrDefault();
                    if(reciveritem != null)
                    {
                    reciveritem.Balance += amountSend;
                    item.Balance -= amountSend;
                    Transfer transfer = new Transfer();
                    transfer.Account_No = Convert.ToDecimal(sendacctext.Text);
                    transfer.ToTransfer = Convert.ToDecimal(recivetext.Text);
                    transfer.Date = currentdatelbl.Text;
                    transfer.Name = nametext.Text;
                    transfer.balance = Convert.ToDecimal(amountsendtext.Text);

                    dbe.Transfer.Add(transfer);
                    dbe.SaveChanges();
                    MessageBox.Show("Para gönderildi\n" + item.Account_No + " no'lu hesabın yeni bakiyesi: " + item.Balance);
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir alıcı hesap yok");
                    }
                }
                else
                {
                    MessageBox.Show("Yeterli para yok");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir gönderici hesap yok");
            }

        }
    }
}
