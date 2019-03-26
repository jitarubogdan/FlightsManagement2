using lab3CSharp.domain;
using log4net;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3CSharp.repository
{
    class ZborRepository : IZborRepository
    {
        //private static readonly ILog log = LogManager.GetLogger("ZborRepository");

        IDictionary<String, string> props;

        public ZborRepository(IDictionary<string, string> props)
        {
            this.props = props;
        }

        public void delete(int id)
        {
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Zboruri where Id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("No flight deleted!");
            }
        }

        public IEnumerable<Zbor> findAll()
        {
            IDbConnection con = DBUtils.getConnection(props);
            IList<Zbor> zboruri = new List<Zbor>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Zboruri";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int IdZ = dataR.GetInt32(0);
                        String destinatie = dataR.GetString(1);
                        DateTime plecare = DateTime.Parse(dataR.GetString(2));
                        String aeroport = dataR.GetString(3);
                        int locuri = dataR.GetInt32(4);
                        Zbor z = new Zbor(IdZ, destinatie, plecare, aeroport, locuri);  
                        zboruri.Add(z);
                    }
                }
            }

            return zboruri;
        }

        public Zbor findByDestinatieAndTime(string destinatie, string time)
        {
            IDbConnection con = DBUtils.getConnection(props);

            IList<Zbor> zboruri = new List<Zbor>();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Zboruri where Destinatie=@destinatie and Plecare=@time";
                IDbDataParameter paramDestinatie = comm.CreateParameter();
                paramDestinatie.ParameterName = "@destinatie";
                paramDestinatie.Value = destinatie;
                comm.Parameters.Add(paramDestinatie);

                IDbDataParameter paramData = comm.CreateParameter();
                paramData.ParameterName = "@time";
                paramData.Value = time;
                comm.Parameters.Add(paramData);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int IdZ = dataR.GetInt32(0);
                        String destinatie2 = dataR.GetString(1);
                        DateTime plecare = DateTime.Parse(dataR.GetString(2));
                        String aeroport = dataR.GetString(3);
                        int locuri = dataR.GetInt32(4);
                        Zbor z = new Zbor(IdZ, destinatie2, plecare, aeroport, locuri);

                        //log.InfoFormat("Exiting findOne with value {0}", c);
                        return z;
                    }
                }
            }
            //log.InfoFormat("Exiting findOne with value {0}", null);
            return null;
        }

        public IEnumerable<Zbor> findByDestinatieData(string destinatie, string data)
        {
            IDbConnection con = DBUtils.getConnection(props);

            IList<Zbor> zboruri = new List<Zbor>();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Zboruri where Destinatie=@destinatie and date(Plecare)=@data";
                IDbDataParameter paramDestinatie = comm.CreateParameter();
                paramDestinatie.ParameterName = "@destinatie";
                paramDestinatie.Value = destinatie;
                comm.Parameters.Add(paramDestinatie);

                IDbDataParameter paramData = comm.CreateParameter();
                paramData.ParameterName = "@data";
                paramData.Value = data;
                comm.Parameters.Add(paramData);

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int IdZ = dataR.GetInt32(0);
                        String destinatie2 = dataR.GetString(1);
                        DateTime plecare = DateTime.Parse(dataR.GetString(2));
                        String aeroport = dataR.GetString(3);
                        int locuri = dataR.GetInt32(4);
                        Zbor z = new Zbor(IdZ, destinatie2, plecare, aeroport, locuri);

                        //log.InfoFormat("Exiting findOne with value {0}", c);
                        zboruri.Add(z);
                    }
                }
            }
            //log.InfoFormat("Exiting findOne with value {0}", null);
            return zboruri;
        }

        public Zbor findOne(int id)
        {
            IDbConnection con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Zboruri where Id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int IdZ = dataR.GetInt32(0);
                        String destinatie = dataR.GetString(1);
                        DateTime plecare = DateTime.Parse(dataR.GetString(2));
                        String aeroport = dataR.GetString(3);
                        int locuri = dataR.GetInt32(4);
                        Zbor z = new Zbor(IdZ, destinatie, plecare, aeroport, locuri);
                        
                        //log.InfoFormat("Exiting findOne with value {0}", c);
                        return z;
                    }
                }
            }
            //log.InfoFormat("Exiting findOne with value {0}", null);
            return null;
        }

        public void save(Zbor entity)
        {
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Zboruri values (@idZ, @destinatie, @plecare, @aeroport, @locuri)";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@idZ";
                paramId.Value = entity.Id;
                comm.Parameters.Add(paramId);

                var paramDestinatie = comm.CreateParameter();
                paramDestinatie.ParameterName = "@destinatie";
                paramDestinatie.Value = entity.Destinatie;
                comm.Parameters.Add(paramDestinatie);

                var paramPlecare = comm.CreateParameter();
                paramPlecare.ParameterName = "@plecare";
                paramPlecare.Value = entity.Plecare;
                comm.Parameters.Add(paramPlecare);

                var paramAeroport = comm.CreateParameter();
                paramAeroport.ParameterName = "@aeroport";
                paramAeroport.Value = entity.Aeroport;
                comm.Parameters.Add(paramAeroport);

                var paramLocuri = comm.CreateParameter();
                paramLocuri.ParameterName = "@locuri";
                paramLocuri.Value = entity.Locuri;
                comm.Parameters.Add(paramLocuri);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No flight added !");
            }
        }

        public void updateLocuri(int id, int locuriRamase)
        {
            IDbConnection con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "update Zboruri set Locuri=@locuri where Id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);

                IDbDataParameter paramLocuri = comm.CreateParameter();
                paramLocuri.ParameterName = "@locuri";
                paramLocuri.Value = locuriRamase;
                comm.Parameters.Add(paramLocuri);

                var dataR = comm.ExecuteNonQuery();
            
            }
        }   
    }
}
