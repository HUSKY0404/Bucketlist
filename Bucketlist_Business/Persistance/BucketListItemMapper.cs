using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Bucketlist_Business.Business;

namespace Bucketlist_Business.Persistance
{
    class BucketListItemMapper
    {
        private string _connectionString;
        public BucketListItemMapper()
        {
            _connectionString = "server = localhost; user id = root;password=1234; database=bucketlistdb";
        }
        public BucketListItemMapper(string connectionstring)
        {
            _connectionString = connectionstring;
        }
        public List<BucketListItem> getBucketListItemsFromDB()
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            MySqlCommand cmd = new MySqlCommand("select * from bucketlistdb.bucketlistitem", conn);
            List<BucketListItem> bucketListItemLijst = new List<BucketListItem>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                BucketListItem bucketlist = new BucketListItem(
                Convert.ToInt16(dataReader[0]),
                dataReader[1].ToString(),
                dataReader[2].ToString()
                );
                bucketListItemLijst.Add(bucketlist);
            }
            conn.Close();
            return bucketListItemLijst;
        }

        public void addBucketListItemToDB(BucketListItem bli)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "INSERT INTO bucketlistdb.bucketlistitem(naam, omschrijving) VALUES(@naam, @omsch)";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("naam", bli.naam);
            cmd.Parameters.AddWithValue("omsch", bli.omschrijving);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void removeBucketlistItemFromDB(int id)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "DELETE FROM bucketlistdb.bucketlistitem WHERE (id = @id);";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
