using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        public abstract string SetName();
        public abstract string getRoshambo();
    }

    class EasyBot : Player
    {
        string name;
        public override string SetName()
        {
            return "Easy Bot";
        }
        public override string getRoshambo()
        {
            return "rock";
        }
    }
    class HardBot : Player
    {
        public override string SetName()
        {
            return "Hard Bot";
        }
        public override string getRoshambo()
        {
            Random rng = new Random();
            int shoot = (rng.Next(0, 2));
            return rps[shoot];
        }
    }
    class User : Player
    {
        public override string SetName()
        {
            string userName = Console.ReadLine();
            return userName;
        }
        public string GetName()
        {
            return SetName();
        }
        public override string getRoshambo()
        {
            string userShoot = Console.ReadLine();
            return userShoot;
        }
    }
}
