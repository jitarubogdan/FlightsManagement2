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
    class ClientRepository : IClientRepository
    {
        private static readonly ILog log = LogManager.GetLogger("ClientRepository");

        IDictionary<String, string> props;
        public ClientRepository(IDictionary<String, string> props)
        {
            log.Info("Creating ClientRepository ");
            this.props = props;
        }

        public Client findOne(int id)
        {
            log.InfoFormat("Entering findOne with value {0}", id);
            IDbConnection con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Clienti where Id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int IdC = dataR.GetInt32(0);
                        String Nume = dataR.GetString(1);
                        String Adresa = dataR.GetString(2);


                        Client c = new Client(IdC, Nume, Adresa);
                        log.InfoFormat("Exiting findOne with value {0}", c);
                        return c;
                    }
                }
            }
            log.InfoFormat("Exiting findOne with value {0}", null);
            return null;
        }

        public IEnumerable<Client> findAll()
        {
            IDbConnection con = DBUtils.getConnection(props);
            IList<Client> clients = new List<Client>();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Clienti";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int IdC = dataR.GetInt32(0);
                        String Nume = dataR.GetString(1);
                        String Adresa = dataR.GetString(2);

                        Client c = new Client(IdC, Nume, Adresa);
                        clients.Add(c);
                    }
                }
            }

            return clients;
        }

        public void save(Client entity)
        {
            var con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Clienti  values (@idC, @nume, @adresa)";
                var paramId = comm.CreateParameter();
                paramId.ParameterName = "@idC";
                paramId.Value = entity.Id;
                comm.Parameters.Add(paramId);

                var paramNume = comm.CreateParameter();
                paramNume.ParameterName = "@nume";
                paramNume.Value = entity.Nume;
                comm.Parameters.Add(paramNume);

                var paramAdresa = comm.CreateParameter();
                paramAdresa.ParameterName = "@adresa";
                paramAdresa.Value = entity.Adresa;
                comm.Parameters.Add(paramAdresa);



                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("No client added !");
            }

        }

        public void delete(int id)
        {
            IDbConnection con = DBUtils.getConnection(props);
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Clienti where Id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("No task deleted!");
            }
        }

        public Client findClientByNameAndAdresa(string nume, string adresa)
        {
      
            IDbConnection con = DBUtils.getConnection(props);

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Clienti where Nume=@nume and Adresa=@adresa";
                IDbDataParameter paramNume = comm.CreateParameter();
                paramNume.ParameterName = "@nume";
                paramNume.Value = nume;
                comm.Parameters.Add(paramNume);

                IDbDataParameter paramAdresa = comm.CreateParameter();
                paramAdresa.ParameterName = "@adresa";
                paramAdresa.Value = adresa;
                comm.Parameters.Add(paramAdresa);

                using (var dataR = comm.ExecuteReader())
                {
                    if (dataR.Read())
                    {
                        int IdC = dataR.GetInt32(0);
                        String Nume2 = dataR.GetString(1);
                        String Adresa2 = dataR.GetString(2);


                        Client c = new Client(IdC, Nume2, Adresa2);
                        log.InfoFormat("Exiting findOne with value {0}", c);
                        return c;
                    }
                }
            }
            log.InfoFormat("Exiting findOne with value {0}", null);
            return null;
        }
    }
}
