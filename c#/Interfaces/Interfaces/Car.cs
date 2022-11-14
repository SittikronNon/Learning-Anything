using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Car : Vehical, IDesyroyable
    {

        public string DestructionSound { get; set; }

        public List<IDesyroyable> DestroyablesNearby;

        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;

            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDesyroyable>();
        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruciton sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            foreach(IDesyroyable desyroyable in DestroyablesNearby)
            {
                desyroyable.Destroy();
            }
        }
    }
}
