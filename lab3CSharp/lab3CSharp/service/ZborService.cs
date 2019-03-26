using lab3CSharp.domain;
using lab3CSharp.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.service
{
    class ZborService
    {
        IZborRepository repo;

        public ZborService(IZborRepository repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Zbor> findAll()
        {
            return repo.findAll();
        }

        public IEnumerable<ZborDTO> findByDestinatieData(string destinatie, string data)
        {
            IEnumerable<Zbor> it = repo.findByDestinatieData(destinatie, data);
            IList<Zbor> zboruri = new List<Zbor>(it);
            IList<ZborDTO> zboruriDTO = new List<ZborDTO>();
            foreach(Zbor z in zboruri)
            {
                int hour = z.Plecare.Hour;
                int minute = z.Plecare.Minute;
                zboruriDTO.Add(new ZborDTO(new TimeSpan(hour, minute,0),z.Locuri));
            }
            return zboruriDTO;
        }
    }
}
