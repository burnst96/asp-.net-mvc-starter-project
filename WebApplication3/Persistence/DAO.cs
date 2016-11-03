using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Persistence
{
    interface DAO
    {
        User Select(String tableName, int id);
        void Create(String tableName, User user);
        void Update(String tableName, int id, User user);
        void Delete(String tableName, int id);
    }
}
