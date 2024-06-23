namespace BankingApp
{
    partial class BalanceSheet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.accnotext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.processNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hesapno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gün = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.öncekibakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yatırılanmiktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HesapNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alımgünü = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alınacakpara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.başlangıçgünü = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(747, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tüm Hareketler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No.";
            // 
            // accnotext
            // 
            this.accnotext.Location = new System.Drawing.Point(129, 76);
            this.accnotext.Name = "accnotext";
            this.accnotext.Size = new System.Drawing.Size(259, 22);
            this.accnotext.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(407, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Verileri Al";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.processNo,
            this.date,
            this.accountNo,
            this.name,
            this.oldBalance,
            this.mod,
            this.debAmount});
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 701);
            this.dataGridView1.TabIndex = 4;
            // 
            // processNo
            // 
            this.processNo.DataPropertyName = "sno";
            this.processNo.HeaderText = "İşlem No.";
            this.processNo.MinimumWidth = 6;
            this.processNo.Name = "processNo";
            this.processNo.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.HeaderText = "Tarih";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // accountNo
            // 
            this.accountNo.DataPropertyName = "AccountNo";
            this.accountNo.HeaderText = "Hesap No.";
            this.accountNo.MinimumWidth = 6;
            this.accountNo.Name = "accountNo";
            this.accountNo.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "Ad";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // oldBalance
            // 
            this.oldBalance.DataPropertyName = "OldBalance";
            this.oldBalance.HeaderText = "Önceki bakiye";
            this.oldBalance.MinimumWidth = 6;
            this.oldBalance.Name = "oldBalance";
            this.oldBalance.Width = 125;
            // 
            // mod
            // 
            this.mod.DataPropertyName = "Mode";
            this.mod.HeaderText = "Mod";
            this.mod.MinimumWidth = 6;
            this.mod.Name = "mod";
            this.mod.Width = 125;
            // 
            // debAmount
            // 
            this.debAmount.DataPropertyName = "DebAmount";
            this.debAmount.HeaderText = "Çekilen Miktar";
            this.debAmount.MinimumWidth = 6;
            this.debAmount.Name = "debAmount";
            this.debAmount.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.hesapno,
            this.gün,
            this.Ad,
            this.mode,
            this.öncekibakiye,
            this.yatırılanmiktar});
            this.dataGridView2.Location = new System.Drawing.Point(613, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(574, 701);
            this.dataGridView2.TabIndex = 5;
            // 
            // sno
            // 
            this.sno.DataPropertyName = "sno";
            this.sno.HeaderText = "İşlem No.";
            this.sno.MinimumWidth = 6;
            this.sno.Name = "sno";
            this.sno.Width = 125;
            // 
            // hesapno
            // 
            this.hesapno.DataPropertyName = "AccountNo";
            this.hesapno.HeaderText = "Hesap No.";
            this.hesapno.MinimumWidth = 6;
            this.hesapno.Name = "hesapno";
            this.hesapno.Width = 125;
            // 
            // gün
            // 
            this.gün.DataPropertyName = "Date";
            this.gün.HeaderText = "Tarih";
            this.gün.MinimumWidth = 6;
            this.gün.Name = "gün";
            this.gün.Width = 125;
            // 
            // Ad
            // 
            this.Ad.DataPropertyName = "Name";
            this.Ad.HeaderText = "Ad";
            this.Ad.MinimumWidth = 6;
            this.Ad.Name = "Ad";
            this.Ad.Width = 125;
            // 
            // mode
            // 
            this.mode.DataPropertyName = "Mode";
            this.mode.HeaderText = "Mod";
            this.mode.MinimumWidth = 6;
            this.mode.Name = "mode";
            this.mode.Width = 125;
            // 
            // öncekibakiye
            // 
            this.öncekibakiye.DataPropertyName = "OldBalance";
            this.öncekibakiye.HeaderText = "Önceki Bakiye";
            this.öncekibakiye.MinimumWidth = 6;
            this.öncekibakiye.Name = "öncekibakiye";
            this.öncekibakiye.Width = 125;
            // 
            // yatırılanmiktar
            // 
            this.yatırılanmiktar.DataPropertyName = "DipAmount";
            this.yatırılanmiktar.HeaderText = "Yatırılan Miktar";
            this.yatırılanmiktar.MinimumWidth = 6;
            this.yatırılanmiktar.Name = "yatırılanmiktar";
            this.yatırılanmiktar.Width = 125;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno1,
            this.HesapNo1,
            this.mode1,
            this.lira,
            this.period,
            this.faiz,
            this.alımgünü,
            this.alınacakpara,
            this.başlangıçgünü});
            this.dataGridView3.Location = new System.Drawing.Point(1213, 177);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(574, 701);
            this.dataGridView3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Para çekme işlemleri:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(609, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Para yatırma işlemleri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(1209, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vadeler:";
            // 
            // sno1
            // 
            this.sno1.DataPropertyName = "sno";
            this.sno1.HeaderText = "İşlem No.";
            this.sno1.MinimumWidth = 6;
            this.sno1.Name = "sno1";
            this.sno1.Width = 125;
            // 
            // HesapNo1
            // 
            this.HesapNo1.DataPropertyName = "Account_No";
            this.HesapNo1.HeaderText = "Hesap No.";
            this.HesapNo1.MinimumWidth = 6;
            this.HesapNo1.Name = "HesapNo1";
            this.HesapNo1.Width = 125;
            // 
            // mode1
            // 
            this.mode1.DataPropertyName = "Mode";
            this.mode1.HeaderText = "Mod";
            this.mode1.MinimumWidth = 6;
            this.mode1.Name = "mode1";
            this.mode1.Width = 125;
            // 
            // lira
            // 
            this.lira.DataPropertyName = "Lira";
            this.lira.HeaderText = "Yatırılan Para (TL)";
            this.lira.MinimumWidth = 6;
            this.lira.Name = "lira";
            this.lira.Width = 125;
            // 
            // period
            // 
            this.period.DataPropertyName = "Period";
            this.period.HeaderText = "Periyot";
            this.period.MinimumWidth = 6;
            this.period.Name = "period";
            this.period.Width = 125;
            // 
            // faiz
            // 
            this.faiz.DataPropertyName = "Interest_rate";
            this.faiz.HeaderText = "Faiz";
            this.faiz.MinimumWidth = 6;
            this.faiz.Name = "faiz";
            this.faiz.Width = 125;
            // 
            // alımgünü
            // 
            this.alımgünü.DataPropertyName = "Maturity_Date";
            this.alımgünü.HeaderText = "Alım Günü";
            this.alımgünü.MinimumWidth = 6;
            this.alımgünü.Name = "alımgünü";
            this.alımgünü.Width = 125;
            // 
            // alınacakpara
            // 
            this.alınacakpara.DataPropertyName = "Maturiyt_Amount";
            this.alınacakpara.HeaderText = "Vade Tutarı";
            this.alınacakpara.MinimumWidth = 6;
            this.alınacakpara.Name = "alınacakpara";
            this.alınacakpara.Width = 125;
            // 
            // başlangıçgünü
            // 
            this.başlangıçgünü.DataPropertyName = "Start_Date";
            this.başlangıçgünü.HeaderText = "Başlangıç Günü";
            this.başlangıçgünü.MinimumWidth = 6;
            this.başlangıçgünü.Name = "başlangıçgünü";
            this.başlangıçgünü.Width = 125;
            // 
            // BalanceSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1799, 890);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accnotext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BalanceSheet";
            this.Text = "BalanceSheet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accnotext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn processNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn mod;
        private System.Windows.Forms.DataGridViewTextBoxColumn debAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn hesapno;
        private System.Windows.Forms.DataGridViewTextBoxColumn gün;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn öncekibakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn yatırılanmiktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HesapNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lira;
        private System.Windows.Forms.DataGridViewTextBoxColumn period;
        private System.Windows.Forms.DataGridViewTextBoxColumn faiz;
        private System.Windows.Forms.DataGridViewTextBoxColumn alımgünü;
        private System.Windows.Forms.DataGridViewTextBoxColumn alınacakpara;
        private System.Windows.Forms.DataGridViewTextBoxColumn başlangıçgünü;
    }
}