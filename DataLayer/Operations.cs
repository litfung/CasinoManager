using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessLayer;

namespace DataLayer
{
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Casino casino = new Casino();
        public Security security = new Security();

        public static string lastFrom = "";


        /* public int insertUser(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO userData (FirstName, LastName, Username, Password, IsAdmin) VALUES ('" + info.firstname + "','" + info.lastname + "','" + info.username + "','" + info.password + "','" + info.isadmin + "')";
            return db.ExeNonQuery(cmd);
        } */

        public int insertCasino(Casino casino)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO casinoDATA (CasinoName, ClubName, CasinoLocation, OwnerFirstName, OwnerLastName, OwnerEmail, Username, Password, UserGuid) " +
                "VALUES ('" + casino.casinoname + "','" + casino.clubname + "','" + casino.casinolocation + "','" + casino.firstname + "','" + casino.lastname + "'," +
                "'" + casino.email + "','" + casino.username + "','" + casino.password + "','" + casino.userguid+ "')";
            return db.ExeNonQuery(cmd);
        }

        /* public DataTable loginUser(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM userData WHERE Username='" + info.username + "' and Password='" + info.password + "'";
            return db.ExeReader(cmd);
        } */

        public DataTable loginCasino(Casino casino)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM casinoData WHERE OwnerName='" + casino.username + "'";
            return db.ExeReader(cmd);
        }

    }
}
