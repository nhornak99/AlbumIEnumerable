using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IEnumerablePractice
{
    class Album : IEnumerable
    {
        List<Album> albums = null;
        Album[] albumArray = null;
        int index = 0;

        public string Artist { get; set; }
        public string Name { get; set; }

        public Album()
        {
            albums = new List<Album>();
            albumArray = new Album[10];
        }

        public void AddToList(Album album)
        {
            albums.Add(album);
        }

        public void AddToArray(Album album)
        {
            albumArray[index] = album;
            index++;
        }

        public IEnumerator GetEnumerator()
        {
            Console.WriteLine("Album List:");

            foreach (Album a in albums)
            {
                if (a == null)
                {
                    break;
                }
                yield return a;
            }

            Console.WriteLine("\n" + "Album Array:");

            foreach(Album a in albumArray)
            {
                if (a == null)
                {
                    break;
                }
                yield return a;
            }
        }
    }
}
