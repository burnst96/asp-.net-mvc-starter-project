using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Persistence
{
    public class OracleDAO : DAO
    {
        DbConnection connect;

        public OracleDAO()
        {
            connect.ConnectionString = "Data Source=digitaldev/letmein@//localhost:1521/;";
            connect.Open();
        }

        public void Create(string tableName, User user)
        {
            
        }

        public void Delete(string tableName, int id)
        {
        }

        public User Select(string tableName, int id)
        {
            return null;
        }

        public void Update(string tableName, int id, User user)
        {
        }
    }
}