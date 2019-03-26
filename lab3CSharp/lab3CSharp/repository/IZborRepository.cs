using lab3CSharp.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.repository
{
    interface IZborRepository : ICrudRepository<int, Zbor>
    {
        IEnumerable<Zbor> findByDestinatieData(String destinatia, String data);
        Zbor findByDestinatieAndTime(String destinatie, String time);

        void updateLocuri(int id, int locuriRamase);
    }
}
