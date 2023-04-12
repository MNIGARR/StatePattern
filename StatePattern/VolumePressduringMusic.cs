using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class VolumePressduringMusic : State
    {
        public void PressUpVolume()
        {
            Console.WriteLine("Ses artirilir...");
        }
        public void PressDownVolume()
        {
            Console.WriteLine("Ses azaldilir...");
        }
        public void PressStop()
        {
            Console.WriteLine("Mahni dayandirildi!!");
        }
    }
}
