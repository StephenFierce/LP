using LPProject.Core.Connection;
using LPProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Core.Contexts
{
    public class StemmenContext : IContext<Stemmen>
    {
        private PartijContext _partijContext;
        private readonly IDatabaseConnector _connector;
        public StemmenContext(IDatabaseConnector connector)
        {
            _partijContext = new PartijContext(connector);
            _connector = connector;
        }
        public void Create(Stemmen item, int id = 0)
        {
            throw new NotImplementedException();
        }

        public void Delete(Stemmen item)
        {
            throw new NotImplementedException();
        }

        public Stemmen GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Stemmen> Read(int id = 0)
        {
            string query = "";
            int ID = id;
            List<Stemmen> Stemmen = new List<Stemmen>();
            // Stemmen Stemmen = null;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                if (ID == 0)
                {
                    query = "SELECT * FROM [dbo].[Stemmen] WHERE [Hidden] IS NULL;";
                }
                else
                {
                    query = "SELECT * FROM [dbo].[Stemmen] WHERE [Hidden] IS NULL AND [Uitslag_ID] = @ID;";

                }
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (ID != 0)
                    {
                        cmd.Parameters.AddWithValue("ID", ID);
                    }
                    //cmd.Parameters.AddWithValue("@id", someparm;)
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Stemmen stem = new Stemmen();

                                stem.AantalStemmen = reader.GetInt32(3);
                                stem.Partij = _partijContext.Read(reader.GetInt32(1))[0];

                                Stemmen.Add(stem);
                            }
                        }
                    }
                }
            }

            return Stemmen;
        }

        public void Update(Stemmen item)
        {
            throw new NotImplementedException();
        }
    }
}
