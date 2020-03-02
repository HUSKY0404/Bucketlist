using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Bucketlist_Business.Business;

namespace Bucketlist_Business.Persistance
{
    class userHasBucketListItemMapper
    {
        private string _connectionString;
        public userHasBucketListItemMapper()
        {
            _connectionString = "server = localhost; user id = root;password=1234; database=bucketlistdb";
        }
        public userHasBucketListItemMapper(string connectionstring)
        {
            _connectionString = connectionstring;
        }
        public List<UserHasBucketListItem> getUsersBucketListItemsFromDB(int idUser)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            MySqlCommand cmd = new MySqlCommand("SELECT user.Naam as username," +
                " bucketlistitem.Naam as bucketlistitemname, " +
                "user_has_bucketlistitem.Leeftijd, " +
                "user_has_bucketlistitem.AlGedaan" +
                " FROM bucketlistdb.user_has_bucketlistitem " +
                "inner join bucketlistdb.bucketlistitem " +
                "on user_has_bucketlistitem.BucketlistItem_idBucketlistItem = bucketlistitem.idBucketlistItem" +
                " inner join bucketlistdb.user on user_has_bucketlistitem.User_idUser = @param0;", conn);
            cmd.Parameters.AddWithValue("param0", idUser);
            List<UserHasBucketListItem> bucketListItemLijst = new List<UserHasBucketListItem>();
            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                UserHasBucketListItem bucketlist = new UserHasBucketListItem(
                dataReader[0].ToString(),
                dataReader[1].ToString(),
                dataReader[2].ToString(),
                Convert.ToBoolean(dataReader[3])
                );
                bucketListItemLijst.Add(bucketlist);
            }
            conn.Close();
            return bucketListItemLijst;
        }

        public void addItemToYourBucketList(int idItem, int idUser)
        {
            //de connectie met de databank maken
            MySqlConnection conn = new MySqlConnection(_connectionString);

            //Het SQL-commando definiëren
            string opdracht = "INSERT INTO bucketlistdb.user_has_bucketlistitem (User_idUser, BucketlistItem_idBucketlistItem) VALUES (@idUser, @idItem)";
            MySqlCommand cmd = new MySqlCommand(opdracht, conn);

            //voeg de waarden toe, je haalt ze uit het object eval
            cmd.Parameters.AddWithValue("idUser", idUser);
            cmd.Parameters.AddWithValue("idItem", idItem);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
