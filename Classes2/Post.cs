using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    public class Post
    {
        //Properties: Title, Description, DateTime when was created

        public string Title { get; set; }
        public string  Description { get; set; }
        public DateTime Creation { get; set; }
        private int Votes { get; set; }
        //Methods: Vote up, Vote down, see  current vote value


        public  Post()
        {
            Votes = 0;
            Creation = DateTime.Now;
        }


        public void VoteUp()
        {
            Votes++;
        }

       public void VoteDown()
        {
            Votes--;
        }

        public int GetVotes()
        {
            int votes = Votes;
            return votes;
         
        }
    }
}
