using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Roshambo
    {
        private string[] rps = { "rock", "paper", "scissors" };

        public string GetRoshambo(int index)
        {
            string get = rps[index];
            return get;
        }
    }
}
