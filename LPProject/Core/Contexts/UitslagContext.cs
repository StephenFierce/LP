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
        public void Create(Uitslag item, int id = 0)
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

                    
                    
                    

                }
                query = "SELECT TOP 1 * FROM [dbo].[Uitslag] Order by [Id] DESC";
                using (SqlCommand cmdThree = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmdThree.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nieuweuitslag.ID = reader.GetInt32(0);
                        }
                    }
                    cmdThree.Parameters.Clear();
                }
                query = "INSERT INTO [dbo].[Stemmen] ([Partij_ID], [Uitslag_ID], [AantalStemmen]) VALUES (@PartijID, @UitslagID, @AantalStemmen)";
                using (SqlCommand cmdTwo = new SqlCommand(query, con))
                {
                    foreach (Stemmen stem in uitslag.Stemmen)
                    {
                        cmdTwo.Parameters.Clear();
                        cmdTwo.Parameters.AddWithValue("PartijID", stem.Partij.ID);
                        cmdTwo.Parameters.AddWithValue("UitslagID", nieuweuitslag.ID);
                        cmdTwo.Parameters.AddWithValue("AantalStemmen", stem.AantalStemmen);
                        cmdTwo.ExecuteNonQuery();
                    }
                    
                }
                con.Close();
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

        public List<Uitslag> Read(int id = 0)
        {
            string query = "";
            int ID = id;
            List<Uitslag> uitslagen = new List<Uitslag>();
            // uitslag uitslag = null;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                if (ID == 0)
                {
                    query = "SELECT * FROM [dbo].[Uitslag] WHERE [Hidden] IS NULL;";
                }
                else
                {
                    query = "SELECT * FROM [dbo].[Uitslag] WHERE [Hidden] IS NULL AND [ID] = @ID;";

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
