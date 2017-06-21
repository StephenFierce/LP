using LPProject.Core.Connection;
using LPProject.Core.Enumerations;
using LPProject.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPProject.Core.Contexts
{
    public class CoalitieContext : IContext<Coalitie>
    {
        private readonly IDatabaseConnector _connector;
        private readonly UitslagContext _uitslagContext;
        public CoalitieContext(IDatabaseConnector connector)
        {
            _uitslagContext = new UitslagContext(connector);
            _connector = connector;
        }
        public void Create(Coalitie item, int id = 0)
        {
            Coalitie coalitie = item;
            
            Coalitie nieuweCoalitie = new Coalitie();
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "INSERT INTO [dbo].[Coalitie] ([Naam], [Lijsttrekker]) VALUES (@Naam, @Lijsttrekker)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("UitslagID", coalitie.Uitslag.ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    query = "INSERT INTO [dbo].[CoalitiePartij] ([Coalitie_ID], [Partij_ID]) VALUES (@CoalitieID, @PartijID)";
                    foreach (Partij partij in coalitie.Partijen)
                    {
                        cmd.Parameters.AddWithValue("CoalitieID", coalitie.ID);
                        cmd.Parameters.AddWithValue("PartijID", partij.ID);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();

                }
            }
        }

        public void Delete(Coalitie item)
        {
            Coalitie coalitie = item;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "UPDATE [dbo].[Coalitie] SET [Hidden] = 'True' WHERE ID = @ID; ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("ID", coalitie.ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public Coalitie GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Coalitie> Read(int accountId = 0)
        {
            List<Coalitie> coalities = new List<Coalitie>();
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "SELECT C.Id, C.Uitslag_ID, P.Id, P.Naam, P.Lijsttrekker FROM [dbo].[Coalitie] C JOIN[dbo].[CoalitiePartij] CP ON CP.Coalitie_ID = C.Id JOIN[dbo].[Partij] P ON P.Id = CP.Partij_ID Where c.Id = 1;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    //cmd.Parameters.AddWithValue("@id", someparm;)
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Coalitie coalitie = new Coalitie();

                                coalitie.ID = reader.GetInt32(0);
                                int uitslagID = reader.GetInt32(1);
                                coalitie.Uitslag = _uitslagContext.Read(uitslagID)[0];
                                query = "SELECT [Partij_ID] FROM [dbo].[CoalitiePartij] WHERE [Coalitie_ID] = @CoalitieID";
                                cmd.Parameters.AddWithValue("CoalitieID", coalitie.ID);
                                //foreach (Partij partij in)
                                //{

                                //    cmd.Parameters.AddWithValue("ID", coalitie.ID);
                                //    cmd.Parameters.AddWithValue("PartijID", partij.ID);
                                //    cmd.ExecuteNonQuery();
                                //}

                                coalities.Add(coalitie);
                            }
                        }
                    }
                }
            }

            return coalities;
        }

        public void Update(Coalitie item)
        {
            Coalitie coalitie = item;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "UPDATE [dbo].[Coalitie] SET [Naam] = @Naam, [Lijsttrekker] = @Lijsttrekker WHERE ID = @ID; ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("ID", coalitie.ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
