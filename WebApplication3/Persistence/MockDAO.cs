using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Persistence
{
    public static class MockDAO
    {

        static SortedList Users = new SortedList();

        public static int generateNewUserID()
        {
            return Users.Count;
        }

        public static void Create(string tableName, User user)
        {
            //NO FUNCTION
        }

        public static void Delete(string tableName, int id)
        {
            Users.Remove(id);
        }

        public static User Select(string tableName, int id)
        {
            return (User) Users.GetByIndex(Users.IndexOfKey(id));
        }

        public static void Update(string tableName, int id, User user)
        {
            int originalIndex = Users.IndexOfKey(id);

            if (originalIndex >= 0) {
                user.id = id;
                Users.Remove(originalIndex);
                Users.Add(id,user);
            }
        }

        public static void Insert(string tableName, User user)
        {
            Users.Add(user.id, user);
        }
    }
}