using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FavouriteAnimal
{
    class CommandLineArguement
    {
        public void AddFavouriteAnimal(string animalToStore)
        {
            try
            {
                using (StreamWriter file = File.AppendText(@"../../favourites.txt"))
                {
                    file.WriteLine(animalToStore);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Unable to add: no animal provided");
            }
        }

        public void RunWithoutArguement()
        {
            Console.WriteLine("C# FavouriteAnimals command arguements: \n[cat][cat] - it will add cat to the list \n[horse][horse] " +
                "\n[poni][poni] \n[snake][snake] \n[animal][animal] - if you want to add any other animal then my four favourite");
        }
    }
}
