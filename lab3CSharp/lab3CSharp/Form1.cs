using lab3CSharp.domain;
using lab3CSharp.repository;
using lab3CSharp.service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3CSharp
{
    public partial class Form1 : Form
    {
        DataSet ds;
        SQLiteDataAdapter adapter;
        ClientService srvC;
        ZborService srvZ;
        BiletService srvB;
        private ObservableCollection<Zbor> model = new ObservableCollection<Zbor>();

        public Form1()
        {
            InitializeComponent();
        }

        internal void setService(ClientService srvC, ZborService srvZ, BiletService srvB)
        {
            this.srvC = srvC;
            this.srvZ = srvZ;
            this.srvB = srvB;
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
            IEnumerable<Zbor> list = srvZ.findAll();
            List<Zbor> list2 = new List<Zbor>(list);
            dataGridViewClienti.DataSource = list2;
            dataGridViewClienti.Columns["Id"].Visible = false;
        }

        private void dataGridViewClienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewSmall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cautaButton_Click(object sender, EventArgs e)
        {

            string destinatie = destinatieBox.Text;
            string data = dataBox.Text;

            IEnumerable<ZborDTO> list = srvZ.findByDestinatieData(destinatie, data);
            List<ZborDTO> list2 = new List<ZborDTO>(list);
            dataGridViewSmall.DataSource = list2;
        }

        private void adaugaButton_Click(object sender, EventArgs e)
        {
            string destinatie = destinatieBox.Text;
            string data = dataBox.Text;
            string ora = oraBox.Text;
            string nume = numeBox.Text;
            string adresa = adresaBox.Text;
            string locuri = locuriBox.Text;
            string turisti = turistiBox.Text;

            srvB.AddBilet(destinatie, data, ora, nume, adresa, locuri, turisti);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
