namespace BankingApp
{
    partial class PasswordChange
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.oldpasstext = new System.Windows.Forms.TextBox();
            this.newpasstext = new System.Windows.Forms.TextBox();
            this.newagaintext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(344, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(31, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eski Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(31, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yeni Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(31, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yeni Şifreyi Doğrula";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(380, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Değiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oldpasstext
            // 
            this.oldpasstext.Location = new System.Drawing.Point(232, 107);
            this.oldpasstext.Name = "oldpasstext";
            this.oldpasstext.Size = new System.Drawing.Size(254, 22);
            this.oldpasstext.TabIndex = 5;
            // 
            // newpasstext
            // 
            this.newpasstext.Location = new System.Drawing.Point(232, 183);
            this.newpasstext.Name = "newpasstext";
            this.newpasstext.Size = new System.Drawing.Size(254, 22);
            this.newpasstext.TabIndex = 6;
            // 
            // newagaintext
            // 
            this.newagaintext.Location = new System.Drawing.Point(232, 253);
            this.newagaintext.Name = "newagaintext";
            this.newagaintext.Size = new System.Drawing.Size(254, 22);
            this.newagaintext.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(31, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Yeni Kullanıcı Adı";
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(232, 344);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(254, 22);
            this.usernametext.TabIndex = 9;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 749);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.newagaintext);
            this.Controls.Add(this.newpasstext);
            this.Controls.Add(this.oldpasstext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox oldpasstext;
        private System.Windows.Forms.TextBox newpasstext;
        private System.Windows.Forms.TextBox newagaintext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernametext;
    }
}