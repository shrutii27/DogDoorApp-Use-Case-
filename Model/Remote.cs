using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoorApp_Use_Case_.Model
{
    internal class Remote
    {
        private DogDoor door;
        private Timer timer = new Timer(5000); //set 5 seconds timer
        public Remote(DogDoor door) // Constructor
        {
            this.door = door;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed_CloseDoor);
            //attach an event handler for event

        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button ...");
            ToggleDoorState(); //toggle the state open/close
            AutoCloseDoor(); //start a timer to automatically close the door
        }
        private void ToggleDoorState() //method to check if the door is open or not
        {
            if (door.isOpen)
            {
                door.close(); //if door is open close it
            }
            else
            {
                door.open();
            }
        }
        private void AutoCloseDoor()
        {
            timer.Enabled = true; //enable timer to automatically close the door
        }

        private void timer_Elapsed_CloseDoor(object sender, ElapsedEventArgs e)
        // Method called when the timer elapses
        {
            door.close(); // Close the dog door
            timer.Enabled = false; //disable timer after door is closed
        }
    }
}


