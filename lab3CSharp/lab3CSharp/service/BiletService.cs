using lab3CSharp.domain;
using lab3CSharp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3CSharp.service
{
    class BiletService
    {
        IBiletRepository repoB;
        IClientRepository repoC;
        IZborRepository repoZ;

        public BiletService(IBiletRepository repoB, IClientRepository repoC, IZborRepository repoZ)
        {
            this.repoB = repoB;
            this.repoC = repoC;
            this.repoZ = repoZ;
        }

        public int getCorrectId()
        {
            IEnumerable<Bilet> lista = repoB.findAll();
            IList<Bilet> l = new List<Bilet>(lista);
            int lungime = l.Count;
            return lungime+1;
        }

        internal void AddBilet(string destinatie, string data, string ora, string nume, string adresa, string locuri, string turisti)
        {
            Client c = repoC.findClientByNameAndAdresa(nume, adresa);
            string data2 = data + " " + ora;
            Zbor z = repoZ.findByDestinatieAndTime(destinatie, data2);
            int locuri2 = int.Parse(locuri);
            int id = getCorrectId();
            Bilet b = new Bilet(id, z.Id, c.Id, turisti, locuri2);
            repoB.save(b);
            MessageBox.Show("Bilet rezervat");
            int locuriRamase = z.Locuri - locuri2;
            if(locuriRamase == 0)
            {
                repoZ.delete(z.Id);
            }
            else
            {
                repoZ.updateLocuri(z.Id, locuriRamase);
            }
        }
    }
}
