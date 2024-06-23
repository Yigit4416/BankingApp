using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class newAccount : Form
    {
        String gender = String.Empty;
        string m_status = String.Empty;
        decimal no;
        banking_dbEntities1 BSE;
        MemoryStream ms;


        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            comboBox1.Items.Add("Bursa");
            comboBox1.Items.Add("İstanbul");
            comboBox1.Items.Add("İzmir");
        }

        private void loadaccount()
        {
            BSE = new banking_dbEntities1();
            var item = BSE.userAccount.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accnotext.Text = Convert.ToString(no);
        }

        private void loaddate()
        {
            dateData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(erkekRadio.Checked)
            {
                gender = "Erkek";
            }
            else if(kadınRadio.Checked)
            {
                gender = "Kadın";
            }
            if(evliRadio.Checked)
            {
                m_status = "Evli";
            }
            else if (bekarRadio.Checked)
            {
                m_status = "Bekar";
            }

            BSE = new banking_dbEntities1();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametext.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonenotext.Text;
            acc.Address = addresstext.Text;
            acc.District = disttext.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.Marraige = m_status;
            acc.MothersName = mothertext.Text;
            acc.FathersName = fathertext.Text;
            acc.Balance = Convert.ToDecimal(balancetext.Text);
            acc.Date = dateData.Text;
            acc.Picture = ms.ToArray();
            BSE.userAccount.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("Kaydedildi");

        }
    }
}
