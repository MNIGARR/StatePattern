using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class VolumeButtonduringCamera : State
    {
        public void PressUpVolume()
        {
            Console.WriteLine("Goruntu yaxinlasdirilir...");
        }
        public void PressDownVolume()
        {
            Console.WriteLine("Goruntu uzaglasdirilir...");
        }
        public void PressStop()
        {
            Console.WriteLine("Video yazilmaga basladi....");
        }
    }
}
