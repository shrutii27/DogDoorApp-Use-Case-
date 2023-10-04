using DogDoorApp_Use_Case_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp_Use_Case_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoorSimulator.DogDoorTestPath(2000);

            // Dog returns after door closes
            DogDoorSimulator.DogDoorTestPath(10000);
        }
    }
}
