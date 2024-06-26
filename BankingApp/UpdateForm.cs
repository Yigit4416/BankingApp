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
    public partial class UpdateForm : Form
    {
        banking_dbEntities1 dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;


        public UpdateForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(accounttext.Text);
            var item = dbe.userAccount.Where(a => a.Account_No == accno);
            foreach(var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new banking_dbEntities1();
            string name = nametext.Text;
            var item = dbe.userAccount.Where(a => a.Name == name);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new banking_dbEntities1();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccount.Where(a => a.Account_No == accno).FirstOrDefault();
            accounttext.Text = item.Account_No.ToString();
            nametext.Text = item.Name.ToString();
            momtext.Text = item.MothersName.ToString();
            dadtext.Text = item.FathersName.ToString();
            phonetext.Text = item.PhoneNo.ToString();
            addresstext.Text = item.Address.ToString();
            byte[] img = item.Picture;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            disttext.Text = item.District.ToString();
            statetext.Text = item.State.ToString();
            dateTimePicker1.Value = DateTime.Parse(item.DOB);
            if(item.Gender == "Erkek")
            {
                maleRadio.Checked = true;
            }
            else if(item.Gender == "Kadın")
            {
                womenRadio.Checked = true;
            }
            if(item.Marraige == "Evli")
            {
                marriedRadio.Checked = true;
            }
            else if(item.Marraige == "Bekar")
            {
                unmarriedRadio.Checked = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            if(openfile.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openfile.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                userAccount selectedAccount = bi[selectedIndex];
                bi.RemoveAt(selectedIndex);

                dbe = new banking_dbEntities1();
                decimal accountNumber = selectedAccount.Account_No;
                userAccount accountToDelete = dbe.userAccount.FirstOrDefault(acc => acc.Account_No == accountNumber);

                if (accountToDelete != null)
                {
                    dbe.userAccount.Remove(accountToDelete);
                    dbe.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Hesap databasede bulunamadı.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kullanıcıyı seçin.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dbe = new banking_dbEntities1();
            decimal accountno = Convert.ToDecimal(accounttext.Text);
            userAccount UserAccount = dbe.userAccount.First(s =>  s.Account_No.Equals(accountno));
            UserAccount.Account_No = Convert.ToDecimal(accounttext.Text);
            UserAccount.Name = nametext.Text;
            UserAccount.Date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            UserAccount.MothersName = momtext.Text;
            UserAccount.FathersName = dadtext.Text;
            UserAccount.PhoneNo = phonetext.Text;
            if(maleRadio.Checked)
            {
                UserAccount.Gender = "Erkek";
            }
            else if(womenRadio.Checked)
            {
                UserAccount.Gender = "Kadın";
            }
            if(marriedRadio.Checked)
            {
                UserAccount.Marraige = "Evli";
            }
            else if(unmarriedRadio.Checked)
            {
                UserAccount.Marraige = "Bekar";
            }
            Image img = pictureBox1.Image;
            if(img.RawFormat != null)
            {
                if(ms != null)
                {
                    img.Save(ms, img.RawFormat);
                    UserAccount.Picture = ms.ToArray();
                }
            }
            UserAccount.Address = addresstext.Text;
            UserAccount.District = disttext.Text;
            UserAccount.State = statetext.Text;
            UserAccount.DOB = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            dbe.SaveChanges();
            MessageBox.Show("Bilgiler Güncellendi");
        }
    }
}
