using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.domain
{
    class Bilet : HasId<int>
    {
        public int Id { get; set; }
        public int IdZbor { get; set; }
        public int IdClient { get; set; }
        public String Turisti { get; set; }
        public int Locuri { get; set; }

        public Bilet(int Id, int IdZbor, int IdClient, String Turisti, int Locuri)
        {
            this.Id = Id;
            this.IdZbor = IdZbor;
            this.IdClient = IdClient;
            this.Turisti = Turisti;
            this.Locuri = Locuri;
        }

        public override String ToString()
        {
            return "Bilet{" +
                    "id=" + Id +
                    ", idZbor=" + IdZbor +
                    ", idClient=" + IdClient +
                    ", turisti=" + Turisti +
                    ", locuri=" + Locuri +
                    '}';
        }

    }
}
