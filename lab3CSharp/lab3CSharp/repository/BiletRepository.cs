using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3CSharp.domain;
using log4net;

namespace lab3CSharp.repository
{
    class BiletRepository : IBiletRepository
    {
        private static readonly ILog log = LogManager.GetLogger("BiletRepository");

        IDictionary<String, string> props;

        public BiletRepository(IDictionary<string, string> props)
        {
            this.props = props;
        }

        public void delete(int id)
        {
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Bilete where Id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("No ticket deleted!");
            }
        }

        public IEnumerable<Bilet> findAll()
        {
            IDbConnection con = DBUtils.getConnection(props);
            IList<Bilet> bilete = new List<Bilet>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Bilete";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt32(0);
                        int idZbor = dataR.GetInt32(1);
                        int idClient = dataR.GetInt32(2);
                        String turisti = dataR.GetString(3);
                        int locuri = dataR.GetInt32(4);
                        Bilet b = new Bilet(id, idZbor, idClient, turisti, locuri);
                        bilete.Add(b);
                    }
                }
            }

            return bilete;
        }

        public Bilet findOne(int id)
        {
            IDbConnection con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Bilete where Id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int idB = dataR.GetInt32(0);
                        int idZbor = dataR.GetInt32(1);
                        int idClient = dataR.GetInt32(2);
                        String turisti = dataR.GetString(3);
                        int locuri = dataR.GetInt32(4);
                        Bilet b = new Bilet(idB, idZbor, idClient, turisti, locuri);

                        //log.InfoFormat("Exiting findOne with value {0}", c);
                        return b;
                    }
                }
            }
            //log.InfoFormat("Exiting findOne with value {0}", null);
            return null;
        }

        public void save(Bilet entity)
        {
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Bilete values (@id, @idZbor, @idClient, @turisti, @locuri)";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = entity.Id;
                comm.Parameters.Add(paramId);

                var paramidZbor = comm.CreateParameter();
                paramidZbor.ParameterName = "@idZbor";
                paramidZbor.Value = entity.IdZbor;
                comm.Parameters.Add(paramidZbor);

                var paramidClient = comm.CreateParameter();
                paramidClient.ParameterName = "@idClient";
                paramidClient.Value = entity.IdClient;
                comm.Parameters.Add(paramidClient);

                var paramTuristi = comm.CreateParameter();
                paramTuristi.ParameterName = "@turisti";
                paramTuristi.Value = entity.Turisti;
                comm.Parameters.Add(paramTuristi);

                var paramLocuri = comm.CreateParameter();
                paramLocuri.ParameterName = "@locuri";
                paramLocuri.Value = entity.Locuri;
                comm.Parameters.Add(paramLocuri);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No ticket added !");
            }
        }
    }
}
