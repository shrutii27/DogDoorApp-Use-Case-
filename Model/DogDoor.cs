using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp_Use_Case_.Model
{
    internal class DogDoor
    {
        public bool isOpen { get; set; }
        //indicating door is open

        public DogDoor()
        {
            isOpen = false;//intialize door as closed
        }

        public void open()
        {
            isOpen = true; //set door is open
            Console.WriteLine("The dog doog opens.");
        }
        public void close()
        {
            isOpen = false; //set door is closed
            Console.WriteLine("The dog doog closes.");
        }
    }
}
