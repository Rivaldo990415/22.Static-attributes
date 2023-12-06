using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green DAy", 12);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 23);

            Console.WriteLine(Song.songCount);
            Console.ReadLine();
        }
    }
}
