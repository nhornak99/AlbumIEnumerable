using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerablePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Album MOTM = new Album();
            MOTM.Artist = "Kid Cudi";
            MOTM.Name = "Man on The Moon: The End of Day";

            Album TLOP = new Album();
            TLOP.Artist = "Kanye West";
            TLOP.Name = "The Life of Pablo";

            Album albumList = new Album();
            albumList.AddToList(MOTM);
            albumList.AddToList(TLOP);
            albumList.AddToArray(MOTM);
            albumList.AddToArray(TLOP);

            foreach(Album a in albumList)
            {
                Console.WriteLine(a.Name + " by " + a.Artist);
            }
            Console.ReadLine();
        }
    }
}
