using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface State
    {

        public void PressUpVolume() { }
        public void PressDownVolume() { }
        public void PressStop() { }
        
    }
}
