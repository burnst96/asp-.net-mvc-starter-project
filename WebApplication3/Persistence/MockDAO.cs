using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Persistence
{
    public class MockDAO : DAO
    {

        SortedList Users = new SortedList();

        public int generateNewUserID()
        {
            return Users.Count;
        }

        public void Create(string tableName, User user)
        {
            Users.Add(user.id,user);
        }

        public void Delete(string tableName, int id)
        {
            Users.Remove(id);
        }

        public User Select(string tableName, int id)
        {
            return (User) Users.GetByIndex(Users.IndexOfKey(id));
        }

        public void Update(string tableName, int id, User user)
        {
            int originalIndex = Users.IndexOfKey(id);

            if (originalIndex >= 0) {
                user.id = id;
                Users.Remove(originalIndex);
                Users.Add(id,user);
            }
        }
    }
}