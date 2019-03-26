using lab3CSharp.domain;
using lab3CSharp.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3CSharp
{
    public partial class Form2 : Form
    {
        private AngajatService srvA;
        private ClientService srvC;
        private ZborService srvZ;
        private BiletService srvB;
        public Form2()
        {
            InitializeComponent();
        }

        internal void setService(AngajatService srvA, ClientService srvC, ZborService srvZ, BiletService srvB)
        {
            this.srvA = srvA;
            this.srvC = srvC;
            this.srvZ = srvZ;
            this.srvB = srvB;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string user = userTextBox.Text.ToString();
            string password = passwordTextBox.Text.ToString();
            passwordTextBox.Text = "";
            Angajat result = srvA.isAngajatService(user, password);
            if(result == null)
            {
                MessageBox.Show("User sau parola invalide!","Eroare");
            }
            else
            {              
                Form1 form1 = new Form1();
                form1.setService(srvC, srvZ, srvB);
                form1.ShowDialog();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
