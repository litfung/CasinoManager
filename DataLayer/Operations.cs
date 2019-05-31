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
        public Information info = new Information();


        public int insertUser(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO userData (FirstName, LastName, Username, Password, IsAdmin) VALUES ('" + info.firstname + "','" + info.lastname + "','" + info.username + "','" + info.password + "','" + info.isadmin + "')";
            return db.ExeNonQuery(cmd);
        }
         
        public int insertCasino(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO casinoDATA (CasinoName, ClubName, CasinoLocation, OwnerName) VALUES ('" + info.casinoname + "','" + info.clubname + "','" + info.casinolocation + "','" + info.username + "')";
            return db.ExeNonQuery(cmd);
        }

    }
}
