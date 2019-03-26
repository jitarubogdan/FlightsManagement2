namespace lab3CSharp
{
    partial class Form1
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
            this.dataGridViewClienti = new System.Windows.Forms.DataGridView();
            this.dataGridViewSmall = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cautaButton = new System.Windows.Forms.Button();
            this.adaugaButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.destinatieBox = new System.Windows.Forms.TextBox();
            this.dataBox = new System.Windows.Forms.TextBox();
            this.oraBox = new System.Windows.Forms.TextBox();
            this.numeBox = new System.Windows.Forms.TextBox();
            this.adresaBox = new System.Windows.Forms.TextBox();
            this.locuriBox = new System.Windows.Forms.TextBox();
            this.turistiBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClienti
            // 
            this.dataGridViewClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClienti.Location = new System.Drawing.Point(28, 26);
            this.dataGridViewClienti.Name = "dataGridViewClienti";
            this.dataGridViewClienti.RowTemplate.Height = 24;
            this.dataGridViewClienti.Size = new System.Drawing.Size(507, 456);
            this.dataGridViewClienti.TabIndex = 0;
            this.dataGridViewClienti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClienti_CellContentClick);
            // 
            // dataGridViewSmall
            // 
            this.dataGridViewSmall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSmall.Location = new System.Drawing.Point(542, 26);
            this.dataGridViewSmall.Name = "dataGridViewSmall";
            this.dataGridViewSmall.RowTemplate.Height = 24;
            this.dataGridViewSmall.Size = new System.Drawing.Size(327, 456);
            this.dataGridViewSmall.TabIndex = 1;
            this.dataGridViewSmall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSmall_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(894, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destinatia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(898, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(895, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(898, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nume:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(898, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Adresa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(901, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nr. locuri:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(901, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Turisti:";
            // 
            // cautaButton
            // 
            this.cautaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cautaButton.Location = new System.Drawing.Point(898, 132);
            this.cautaButton.Name = "cautaButton";
            this.cautaButton.Size = new System.Drawing.Size(86, 32);
            this.cautaButton.TabIndex = 9;
            this.cautaButton.Text = "Cauta";
            this.cautaButton.UseVisualStyleBackColor = true;
            this.cautaButton.Click += new System.EventHandler(this.cautaButton_Click);
            // 
            // adaugaButton
            // 
            this.adaugaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adaugaButton.Location = new System.Drawing.Point(904, 442);
            this.adaugaButton.Name = "adaugaButton";
            this.adaugaButton.Size = new System.Drawing.Size(97, 39);
            this.adaugaButton.TabIndex = 10;
            this.adaugaButton.Text = "Adauga";
            this.adaugaButton.UseVisualStyleBackColor = true;
            this.adaugaButton.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(1143, 442);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(104, 39);
            this.logoutButton.TabIndex = 11;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // destinatieBox
            // 
            this.destinatieBox.Location = new System.Drawing.Point(1036, 45);
            this.destinatieBox.Name = "destinatieBox";
            this.destinatieBox.Size = new System.Drawing.Size(211, 22);
            this.destinatieBox.TabIndex = 12;
            // 
            // dataBox
            // 
            this.dataBox.Location = new System.Drawing.Point(1036, 85);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(211, 22);
            this.dataBox.TabIndex = 13;
            // 
            // oraBox
            // 
            this.oraBox.Location = new System.Drawing.Point(1036, 182);
            this.oraBox.Name = "oraBox";
            this.oraBox.Size = new System.Drawing.Size(211, 22);
            this.oraBox.TabIndex = 14;
            // 
            // numeBox
            // 
            this.numeBox.Location = new System.Drawing.Point(1036, 218);
            this.numeBox.Name = "numeBox";
            this.numeBox.Size = new System.Drawing.Size(211, 22);
            this.numeBox.TabIndex = 15;
      
            // 
            // adresaBox
            // 
            this.adresaBox.Location = new System.Drawing.Point(1036, 259);
            this.adresaBox.Name = "adresaBox";
            this.adresaBox.Size = new System.Drawing.Size(211, 22);
            this.adresaBox.TabIndex = 16;
            // 
            // locuriBox
            // 
            this.locuriBox.Location = new System.Drawing.Point(1036, 302);
            this.locuriBox.Name = "locuriBox";
            this.locuriBox.Size = new System.Drawing.Size(211, 22);
            this.locuriBox.TabIndex = 17;
            // 
            // turistiBox
            // 
            this.turistiBox.Location = new System.Drawing.Point(1036, 346);
            this.turistiBox.Name = "turistiBox";
            this.turistiBox.Size = new System.Drawing.Size(211, 22);
            this.turistiBox.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 516);
            this.Controls.Add(this.turistiBox);
            this.Controls.Add(this.locuriBox);
            this.Controls.Add(this.adresaBox);
            this.Controls.Add(this.numeBox);
            this.Controls.Add(this.oraBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.destinatieBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.adaugaButton);
            this.Controls.Add(this.cautaButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSmall);
            this.Controls.Add(this.dataGridViewClienti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClienti;
        private System.Windows.Forms.DataGridView dataGridViewSmall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cautaButton;
        private System.Windows.Forms.Button adaugaButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.TextBox destinatieBox;
        private System.Windows.Forms.TextBox dataBox;
        private System.Windows.Forms.TextBox oraBox;
        private System.Windows.Forms.TextBox numeBox;
        private System.Windows.Forms.TextBox adresaBox;
        private System.Windows.Forms.TextBox locuriBox;
        private System.Windows.Forms.TextBox turistiBox;
    }
}

