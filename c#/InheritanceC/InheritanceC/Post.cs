using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class Post
    {
        private static int currentPostId;

        // properties
        protected int ID { get; set; }  

        protected string Title { get; set; }

        protected string SendByUsername { get; set; }
        protected bool IsPublic { get; set; }

        public Post()
        {
            ID = GetNextID();
            Title = "My First Post";
            IsPublic = true;
            SendByUsername = "Sittikron Lamulsab";
        }

        // Instance Constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = 0;
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return currentPostId++;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername);
        }
    }
}
