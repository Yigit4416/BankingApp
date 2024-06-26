namespace BankingApp
{
    partial class TransferView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.sno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gonderilenkisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(376, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Verileri Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno1,
            this.date0,
            this.hesapno,
            this.isim,
            this.tutar,
            this.gonderilenkisi});
            this.dataGridView1.Location = new System.Drawing.Point(67, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1087, 580);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(424, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transferler ";
            // 
            // sno1
            // 
            this.sno1.DataPropertyName = "sno";
            this.sno1.HeaderText = "İşlem No.";
            this.sno1.MinimumWidth = 6;
            this.sno1.Name = "sno1";
            this.sno1.Width = 125;
            // 
            // date0
            // 
            this.date0.DataPropertyName = "Date";
            this.date0.HeaderText = "Tarih";
            this.date0.MinimumWidth = 6;
            this.date0.Name = "date0";
            this.date0.Width = 125;
            // 
            // hesapno
            // 
            this.hesapno.DataPropertyName = "Account_No";
            this.hesapno.HeaderText = "Gönderen Hesap";
            this.hesapno.MinimumWidth = 6;
            this.hesapno.Name = "hesapno";
            this.hesapno.Width = 125;
            // 
            // isim
            // 
            this.isim.DataPropertyName = "Name";
            this.isim.HeaderText = "İsim";
            this.isim.MinimumWidth = 6;
            this.isim.Name = "isim";
            this.isim.Width = 125;
            // 
            // tutar
            // 
            this.tutar.DataPropertyName = "balance";
            this.tutar.HeaderText = "Gönderilen Miktar";
            this.tutar.MinimumWidth = 6;
            this.tutar.Name = "tutar";
            this.tutar.Width = 125;
            // 
            // gonderilenkisi
            // 
            this.gonderilenkisi.DataPropertyName = "ToTransfer";
            this.gonderilenkisi.HeaderText = "Gönderilen Hesap";
            this.gonderilenkisi.MinimumWidth = 6;
            this.gonderilenkisi.Name = "gonderilenkisi";
            this.gonderilenkisi.Width = 125;
            // 
            // TransferView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 810);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "TransferView";
            this.Text = "TransferView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno1;
        private System.Windows.Forms.DataGridViewTextBoxColumn date0;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapno;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn gonderilenkisi;
    }
}