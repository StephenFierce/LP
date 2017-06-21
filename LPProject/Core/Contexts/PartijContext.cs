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
    public class PartijContext : IContext<Partij>
    {
        private readonly IDatabaseConnector _connector;

        public PartijContext(IDatabaseConnector connector)
        {
            _connector = connector;
        }
        public void Create(Partij item, int id = 0)
        {
            Partij partij = item;
            Partij nieuwePartij = new Partij();
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "INSERT INTO [dbo].[Partij] ([Naam], [Lijsttrekker]) VALUES (@Naam, @Lijsttrekker)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("Naam", partij.Naam);
                    cmd.Parameters.AddWithValue("Lijsttrekker", partij.Lijsttrekker);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public void Delete(Partij item)
        {
            Partij partij = item;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "UPDATE [dbo].[Partij] SET [Hidden] = 'True' WHERE ID = @ID; ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("ID", partij.ID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        public Partij GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public Partij GetItem(string naam)
        {
            string query = "";
            string Naam = naam;
            Partij partij = new Partij();
            // uitslag uitslag = null;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                query = "SELECT * FROM [dbo].[Partij] WHERE [Naam] = @Naam;";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("Naam", Naam);
                    //cmd.Parameters.AddWithValue("@id", someparm;)
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                partij.ID = reader.GetInt32(0);
                                partij.Naam = reader.GetString(1);
                                partij.Lijsttrekker = reader.GetString(2);
                            }
                        }
                    }
                }
            }
            return partij;
        }

        public List<Partij> Read(int partijID = 0)
        {
            List<Partij> partijen = new List<Partij>();
            string query = "";
            int ID = partijID;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                if (ID == 0)
                {
                    query = "SELECT * FROM [dbo].[Partij] WHERE [Hidden] IS NULL;";
                }
                else
                {
                    query = "SELECT * FROM [dbo].[Partij] WHERE [Hidden] IS NULL AND [ID] = @ID;";

                }
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("ID", ID);
                    //cmd.Parameters.AddWithValue("@id", someparm;)
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Partij partij = new Partij();

                                partij.ID = reader.GetInt32(0);
                                partij.Naam = reader.GetString(1);
                                partij.Lijsttrekker = reader.GetString(2);

                                partijen.Add(partij);
                            }
                        }
                    }
                }
            }

            return partijen;
        }

        public void Update(Partij item)
        {
            Partij partij = item;
            using (SqlConnection con = new SqlConnection(MSSQLConnector.ConnectionString))
            {
                string query = "UPDATE [dbo].[Partij] SET [Naam] = @Naam, [Lijsttrekker] = @Lijsttrekker WHERE ID = @ID; ";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("ID", partij.ID);
                    cmd.Parameters.AddWithValue("Naam", partij.Naam);
                    cmd.Parameters.AddWithValue("Lijsttrekker", partij.Lijsttrekker);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
