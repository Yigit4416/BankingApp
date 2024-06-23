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
    public partial class FDGoruntule : Form
    {
        public FDGoruntule()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingList<FD> bi = new BindingList<FD>();
            banking_dbEntities1 dbe = new banking_dbEntities1();
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            var item = dbe.FD.Where(a => a.Start_Date.Equals(date));
            dataGridView1.DataSource = item.ToList();
        }
    }
}
