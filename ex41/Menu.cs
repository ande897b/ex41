using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex41
{
   public class Menu
   {
        DatabaseController controller = new DatabaseController();
        public void Run()
        {
            Console.WriteLine("tryk 1 for InsertPet");
            Console.WriteLine("tryk 2 for vis alle dyr");
            string menuValg = Console.ReadLine();
            if (menuValg == "1")
            {
                InsertPet();
            }
            else if (menuValg == "2")
            {
                controller.ShowPets();
            }
            else
            {
                Console.WriteLine("fejl i input, Prøv igen");
            }
            Console.ReadLine();
        }

        private void InsertPet()
        {
            Console.WriteLine("Input name");
            string petName = Console.ReadLine();
            Console.WriteLine("Input Type");
            string petType = Console.ReadLine();
            Console.WriteLine("Input Breed");
            string petBreed = Console.ReadLine();
            Console.WriteLine("input DOB dd/mm/yy");
            string petDOB = Console.ReadLine();
            Console.WriteLine("input Weight");
            string petWeight = Console.ReadLine();
            Console.WriteLine("Input ownerID 1-4");
            string ownerID = Console.ReadLine();
            controller.InsertPet(petName, petType, petBreed, petDOB, petWeight, ownerID);
        }
   }
}
