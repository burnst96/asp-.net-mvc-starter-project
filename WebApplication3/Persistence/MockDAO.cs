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

        public static void Create(User user)
        {
            //NO FUNCTION CURRENTLY
        }

        public static void Delete(int id)
        {
            Users.Remove(id);
        }

        public static User Select(int id)
        {
            return (User) Users.GetByIndex(Users.IndexOfKey(id));
        }

        public static void Update(int id, User user)
        {
            int originalIndex = Users.IndexOfKey(id);

            if (originalIndex >= 0) {
                user.id = id;
                Users.Remove(originalIndex);
                Users.Add(id,user);
            }
        }

        public static void Insert(User user)
        {
            Users.Add(user.id, user);
        }
    }
}