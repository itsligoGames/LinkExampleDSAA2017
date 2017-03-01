using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string GamerTag { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int XP { get; set; }

        public override string ToString()
        {
            return PlayerId.ToString() + " " + 
                GamerTag + " " + FirstName + " " + SecondName + " " + XP.ToString();
        }
    }
}
