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
    public partial class TransferView : Form
    {
        public TransferView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<Transfer> bi = new BindingList<Transfer>();
            banking_dbEntities1 dbe = new banking_dbEntities1();
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            var item = dbe.Transfer.Where(a => a.Date.Equals(date));
            dataGridView1.DataSource = item.ToList();
        }
    }
}
