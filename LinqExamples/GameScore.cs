using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    public class GameScore
    {
        public string GameName { get; set; }
        public string GamerTag { get; set; }
        public DateTime scoredAt { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return GameName + " " + GamerTag + " " + scoredAt.ToString() + " " + Score.ToString();
        }
    }
}
