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

        // change in votes: from outside not should be able to modiify vote -
        //create a readonly field, which will be assigned here in class from VOte
        public string Title { get; set; }
        public string  Description { get; set; }
        private DateTime Creation { get; set; }
        public int Votes { get; set; }
        //Methods: Vote up, Vote down, see  current vote value


        public Post()
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

    }
}
