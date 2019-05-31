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
            cmd.CommandText = "INSERT INTO userData (Name, Username, Password) VALUES ('" + info.name + "','" + info.username + "','" + info.password + "')";
            return db.ExeNonQuery(cmd);
        }

    }
}
