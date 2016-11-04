using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.GPO
{
    public abstract class Course
    {
        private int id;
        private string title;
        private int totalparticipants;

        public int getID()
        {
            return id;
        }
        public string getTitle()
        {
            return title;
        }
        public int getTotalParticipants()
        {
            return totalparticipants;
        }

        public void setID(int id)
        {
            this.id = id;
        }
        public void setName(string title)
        {
            this.title = title;
        }
        public void setTotalParticipants(int totalparticipants)
        {
            this.totalparticipants = totalparticipants;
        }
    }
}