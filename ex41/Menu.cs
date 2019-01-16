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
            var prog = new Program();
            Console.WriteLine("tryk 1 for InsertPet");
            Console.WriteLine("tryk 2 for vis alle dyr");
            string menuValg = Console.ReadLine();
            if (menuValg == "1")
            {
                controller.InsertPet();
            }
            else if (menuValg == "2")
            {
                controller.ShowPets();
            }
            else
            {
                Console.WriteLine("fejl i input, Prøv igen");
            }
        }
    }
}
