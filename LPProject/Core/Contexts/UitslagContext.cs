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
    public class UitslagContext : IContext<Uitslag>
    {
        private readonly IDatabaseConnector _connector;

        public UitslagContext(IDatabaseConnector connector)
        {
            _connector = connector;
        }
        public void Create(Uitslag item)
        {
            Uitslag uitslag = item;
            Uitslag nieuweuitslag = new Uitslag();
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "INSERT INTO [dbo].[Uitslag] ([Datum], [Naam], [Soort_ID]) VALUES (@Datum, @Naam, @Soort)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("Naam", uitslag.Naam);
                    cmd.Parameters.AddWithValue("Soort", uitslag.Soort);
                    cmd.Parameters.AddWithValue("Datum", uitslag.Datum);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    query = "SELECT TOP 1 * FROM [dbo].[Uitslag] Order by [Id] DESC";
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                nieuweuitslag.ID = reader.GetInt32(0);
                            }
                        }
                    }
                    query = "INSERT INTO [dbo].[Stemmen] ([Partij_ID], [Uitslag_ID], [AantalStemmen]) VALUES (@PartijID, @UitslagID, @AantalStemmen)";
                    foreach (Stemmen stem in uitslag.Stemmen)
                    {
                        cmd.Parameters.AddWithValue("PartijID", stem.Partij.ID);
                        cmd.Parameters.AddWithValue("UitslagID", nieuweuitslag.ID);
                        cmd.Parameters.AddWithValue("AantalStemmen", stem.AantalStemmen);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    con.Close();
                }
            }
        }

        public void Delete(Uitslag item)
        {
            Uitslag uitslag = item;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "UPDATE [dbo].[Uitslag] SET [Hidden] = 'True' WHERE ID = @ID; ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("ID", uitslag.ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public Uitslag GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<Uitslag> Read(int accountId = 0)
        {
            List<Uitslag> uitslagen = new List<Uitslag>();
            // uitslag uitslag = null;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "SELECT * FROM [dbo].[Uitslag];";
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
                                Uitslag uitslag = new Uitslag();

                                uitslag.ID = reader.GetInt32(0);
                                uitslag.Datum = reader.GetDateTime(1);
                                uitslag.Naam = reader.GetString(2);
                                uitslag.Soort = (Verkiezingssoort)reader.GetInt32(3);

                                uitslagen.Add(uitslag);
                            }
                        }
                    }
                }
            }

            return uitslagen;
        }

        public void Update(Uitslag item)
        {
            Uitslag uitslag = item;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "UPDATE [dbo].[Uitslag] SET [Naam] = @Naam, [Datum] = @Datum, [Soort_ID] = @Soort WHERE ID = @ID; ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("ID", uitslag.ID);
                    cmd.Parameters.AddWithValue("Soort", Convert.ToInt32(uitslag.Soort));
                    cmd.Parameters.AddWithValue("Naam", uitslag.Naam);
                    cmd.Parameters.AddWithValue("Datum", uitslag.Datum);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
