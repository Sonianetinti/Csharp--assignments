using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__5
{
    public class Q6_Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    class Player
    {
        public class Team : IEnumerable
        {

            List<Q6_Player> q6_Players = new List<Q6_Player>();
            public void Add(Q6_Player Player)
            {
                q6_Players.Add(Player);
            }

            public IEnumerator GetEnumerator()
            {
                return q6_Players.GetEnumerator();
                //throw new NotImplementedException();
            }
        }
        static void Main()
        {
            // List<Q6_Player> Player = new List<Q6_Player>();
            Team Player = new Team();

            Player.Add(new Q6_Player { Id = 121, Name = "peter" });

            Player.Add(new Q6_Player { Id = 101, Name = "henry" });

            foreach (Q6_Player ply in Player)
            {
                Console.WriteLine(ply.Id + " " + ply.Name + " ");

            }

            Console.ReadLine();

        }
    }
}
