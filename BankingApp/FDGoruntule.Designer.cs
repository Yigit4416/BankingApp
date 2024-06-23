namespace BankingApp
{
    partial class FDGoruntule
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
            this.sno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Period = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maturity_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maturty_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sno,
            this.Account_No,
            this.Mode,
            this.Lira,
            this.Period,
            this.Interest_rate,
            this.Maturity_Date,
            this.Maturty_Amount,
            this.Start_Date});
            this.dataGridView1.Location = new System.Drawing.Point(33, 189);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1675, 694);
            this.dataGridView1.TabIndex = 2;
            // 
            // sno
            // 
            this.sno.DataPropertyName = "sno";
            this.sno.HeaderText = "İşlem No.";
            this.sno.MinimumWidth = 6;
            this.sno.Name = "sno";
            this.sno.Width = 125;
            // 
            // Account_No
            // 
            this.Account_No.DataPropertyName = "Account_No";
            this.Account_No.HeaderText = "Hesap No.";
            this.Account_No.MinimumWidth = 6;
            this.Account_No.Name = "Account_No";
            this.Account_No.Width = 125;
            // 
            // Mode
            // 
            this.Mode.DataPropertyName = "Mode";
            this.Mode.HeaderText = "Mod";
            this.Mode.MinimumWidth = 6;
            this.Mode.Name = "Mode";
            this.Mode.Width = 125;
            // 
            // Lira
            // 
            this.Lira.DataPropertyName = "Lira";
            this.Lira.HeaderText = "Yatırılan Miktar";
            this.Lira.MinimumWidth = 6;
            this.Lira.Name = "Lira";
            this.Lira.Width = 125;
            // 
            // Period
            // 
            this.Period.DataPropertyName = "Period";
            this.Period.HeaderText = "Periyot";
            this.Period.MinimumWidth = 6;
            this.Period.Name = "Period";
            this.Period.Width = 125;
            // 
            // Interest_rate
            // 
            this.Interest_rate.DataPropertyName = "Interest_rate";
            this.Interest_rate.HeaderText = "Faiz";
            this.Interest_rate.MinimumWidth = 6;
            this.Interest_rate.Name = "Interest_rate";
            this.Interest_rate.Width = 125;
            // 
            // Maturity_Date
            // 
            this.Maturity_Date.DataPropertyName = "Maturity_Date";
            this.Maturity_Date.HeaderText = "Alım Günü";
            this.Maturity_Date.MinimumWidth = 6;
            this.Maturity_Date.Name = "Maturity_Date";
            this.Maturity_Date.Width = 125;
            // 
            // Maturty_Amount
            // 
            this.Maturty_Amount.DataPropertyName = "Maturiyt_Amount";
            this.Maturty_Amount.HeaderText = "Vade Tutarı";
            this.Maturty_Amount.MinimumWidth = 6;
            this.Maturty_Amount.Name = "Maturty_Amount";
            this.Maturty_Amount.Width = 125;
            // 
            // Start_Date
            // 
            this.Start_Date.DataPropertyName = "Start_Date";
            this.Start_Date.HeaderText = "Başlangıç Günü";
            this.Start_Date.MinimumWidth = 6;
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(752, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vadeler";
            // 
            // FDGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1747, 881);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "FDGoruntule";
            this.Text = "FDGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Period;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maturity_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maturty_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Date;
        private System.Windows.Forms.Label label1;
    }
}